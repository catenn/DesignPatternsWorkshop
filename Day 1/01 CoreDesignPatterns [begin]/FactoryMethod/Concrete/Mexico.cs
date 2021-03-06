﻿using FactoryMethod.Contracts;

namespace FactoryMethod.Concrete
{
    internal class Mexico : IDistributor
    {
        public Carriers Carriers { get;  set; }
        public decimal GrossPricePerPeck { get; set; }
        public string Location { get; set; }
        public bool FdaInspectionRequired { get; set; }

        public Mexico() {}

        public decimal NetPricePerPeck(int deliveryMonth, int deliveryCoordinate, int discountCode)
        {
            // Complex algorithm to determine price for specific client 
            return .13m;
        }
    }
}