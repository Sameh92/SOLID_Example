using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP.Before
{
    public class Consultant : Employee, IEntitlement
    {
        public decimal CalculateBonuses() => Salary * 0.05m;


        public decimal CalculateHealthInsurance() => 300m;


        public decimal CalculatePension()  => throw new NotSupportedException("Consultant Pension not supported");



        public decimal CalculateRentalSubsidy() => throw new NotSupportedException("Consultant Rental Subsidy not supported");


        public decimal CalculateTransportationReimbursement() => 150;

        public override string PrintSalarySlip()
        {
            return $"\n ---{nameof(Consultant)}---" +
                  $"\n NO: {EmployeeNo}" +
                  $"\n Name: {Name}" +
                  $"\n Salary: {Salary.ToString("C2")}" +
                  $"\n Bonuses: {CalculateBonuses().ToString("C2")}" +
                  $"\n Health Insurance: {CalculateHealthInsurance().ToString("C2")}" +                 
                  $"\n Transportation Reimbursement : {CalculateTransportationReimbursement().ToString("C2")}" +
                  $"\n -----------------------------------" +
                  $"\n Net Salary: {CalculateNetSalary().ToString("C2")}";
        }

        protected override decimal CalculateNetSalary()
        {
            return Salary + CalculateBonuses() + CalculateHealthInsurance() + CalculateTransportationReimbursement();
        }
    }


}
