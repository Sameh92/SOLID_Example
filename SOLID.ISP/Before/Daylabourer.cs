using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP.Before
{
    public class Daylabourer : Employee, IEntitlement
    {
        public decimal CalculateBonuses() => throw new NotSupportedException("Day Labourer Bonuses not supported");
     

        public decimal CalculateHealthInsurance() => 300m;
      

        public decimal CalculatePension()=>throw new NotSupportedException("Day Labourer Pension not supported");



        public decimal CalculateRentalSubsidy() => throw new NotSupportedException("Day Labourer Rental not supported");
     

        public decimal CalculateTransportationReimbursement() => 150m;  //Expression body method
       

        public override string PrintSalarySlip()
        {
            return $"\n ---{nameof(Daylabourer)}---" +
                  $"\n NO: {EmployeeNo}" +
                  $"\n Name: {Name}" +
                  $"\n Salary: {Salary.ToString("C2")}" +
                  $"\n Health Insurance: {CalculateHealthInsurance().ToString("C2")}" +
                  $"\n Transportation Reimbursement: {CalculateTransportationReimbursement().ToString("C2")}" +
                  $"\n -----------------------------------" +
                  $"\n Net Salary: {CalculateNetSalary().ToString("C2")}";
        }

        protected override decimal CalculateNetSalary()
        {
            return Salary + CalculateHealthInsurance() + CalculateTransportationReimbursement();
        }
    }
}
