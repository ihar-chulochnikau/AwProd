using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.Services.Productions
{
    public static class ProductExtensions
    {
        public static Product ToProduct(this AdventureWorks.DbModel.Product source)
        {
            if (source == null) return null;

            return new Product
            {
                Class = source.Class,
                Color = source.Color,
                DaysToManufacture = source.DaysToManufacture,
                FinishedGoodsFlag = source.FinishedGoodsFlag,
                ListPrice = source.ListPrice,
                MakeFlag = source.MakeFlag,
                ModifiedDate = source.ModifiedDate,
                Name = source.Name,
                ProductID = source.ProductID,
                ProductLine = source.ProductLine,
                ProductNumber = source.ProductNumber,
                ReorderPoint = source.ReorderPoint,
                rowguid = source.rowguid,
                SafetyStockLevel = source.SafetyStockLevel,
                SellStartDate = source.SellStartDate,
                Size = source.Size,
                SizeUnitMeasureCode = source.SizeUnitMeasureCode,
                StandardCost = source.StandardCost,
                Style = source.Style,
                WeightUnitMeasureCode = source.WeightUnitMeasureCode
            };
        }

        public static DbModel.Product ToDbProduct(this Product source)
        {
            return new DbModel.Product
            {
                Class = source.Class,
                Color = source.Color,
                DaysToManufacture = source.DaysToManufacture,
                FinishedGoodsFlag = source.FinishedGoodsFlag,
                ListPrice = source.ListPrice,
                MakeFlag = source.MakeFlag,
                ModifiedDate = source.ModifiedDate,
                Name = source.Name,
                ProductLine = source.ProductLine,
                ProductNumber = source.ProductNumber,
                ReorderPoint = source.ReorderPoint,
                rowguid = source.rowguid,
                SafetyStockLevel = source.SafetyStockLevel,
                SellStartDate = source.SellStartDate,
                Size = source.Size,
                SizeUnitMeasureCode = source.SizeUnitMeasureCode,
                StandardCost = source.StandardCost,
                Style = source.Style,
                WeightUnitMeasureCode = source.WeightUnitMeasureCode,
                Weight = 23M
            };
        }
    }
}
