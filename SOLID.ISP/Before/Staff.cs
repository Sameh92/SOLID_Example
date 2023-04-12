using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP.Before
{
    public class Staff : Employee, IEntitlement
    {
        public decimal CalculateBonuses() => Salary * 0.05m;
       

        public decimal CalculateHealthInsurance() => 300m;


        public decimal CalculatePension() => .025m * Salary;



        public decimal CalculateRentalSubsidy() => 150;


        public decimal CalculateTransportationReimbursement() => throw new NotSupportedException("Staff Transportation Reimbursement not supported");

        public override string PrintSalarySlip()
        {
            return $"\n ---{nameof(Staff)}---" +
                  $"\n NO: {EmployeeNo}" +
                  $"\n Name: {Name}" +
                  $"\n Salary: {Salary.ToString("C2")}" +
                  $"\n Bonuses: {CalculateBonuses().ToString("C2")}" +
                  $"\n Health Insurance: {CalculateHealthInsurance().ToString("C2")}" +
                  $"\n Pension : {CalculatePension().ToString("C2")}" +
                  $"\n Calculate Rental Subsidy: {CalculateRentalSubsidy().ToString("C2")}" +
                  $"\n -----------------------------------" +
                  $"\n Net Salary: {CalculateNetSalary().ToString("C2")}";
        }

        protected override decimal CalculateNetSalary()
        {
            return Salary + CalculateBonuses() + CalculateHealthInsurance() + CalculatePension() + CalculateRentalSubsidy(); 
        }
    }

}
