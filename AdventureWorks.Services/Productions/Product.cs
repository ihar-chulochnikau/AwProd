using System;

namespace AdventureWorks.Services.Productions
{
    public class Product
    {
        public static Product New()
        {
            return new Product
            {
                rowguid = Guid.NewGuid(),
                SellStartDate = DateTime.Now.Date,
                ModifiedDate = DateTime.Now.Date,
                Class = "H",
                DaysToManufacture = 10,
                ListPrice = 2.59M,
                ProductLine = "R",
                ReorderPoint = 76,
                SafetyStockLevel = 8,
                StandardCost = 2342,
                Style = "U",
                WeightUnitMeasureCode = "LB",
                SizeUnitMeasureCode = "CM",
                Color = "Black",
                FinishedGoodsFlag = false,
                MakeFlag = true,
                Name = "ProductName",
                ProductNumber = "Ar-11231",
                Size = "M",
                ProductID = 3
            };
        }

        public int ProductID { get; set; }

        public string Name { get; set; }

        public string ProductNumber { get; set; }

        public bool MakeFlag { get; set; }

        public bool FinishedGoodsFlag { get; set; }

        public string Color { get; set; }

        public short SafetyStockLevel { get; set; }

        public short ReorderPoint { get; set; }

        public decimal StandardCost { get; set; }

        public decimal ListPrice { get; set; }

        public string Size { get; set; }

        public string SizeUnitMeasureCode { get; set; }

        public string WeightUnitMeasureCode { get; set; }

        public int DaysToManufacture { get; set; }

        public string ProductLine { get; set; }

        public string Class { get; set; }

        public string Style { get; set; }

        public DateTime SellStartDate { get; set; }

        public Guid rowguid { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
