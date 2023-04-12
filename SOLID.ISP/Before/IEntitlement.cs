﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP.Before
{
    public interface IEntitlement
    {
        decimal CalculatePension();
        decimal CalculateHealthInsurance();
        decimal CalculateRentalSubsidy();
        decimal CalculateBonuses();
        decimal CalculateTransportationReimbursement();
    }
}
