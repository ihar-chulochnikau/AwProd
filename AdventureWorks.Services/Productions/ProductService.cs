using System.Collections.Generic;
using System.Linq;

namespace AdventureWorks.Services.Productions
{
    public class ProductService : IProductService
    {
        private readonly DbModel.Entities _entities = new DbModel.Entities();

        public ProductService() { }

        public ICollection<ProductInfo> GetProductInfos()
        {
            var query = _entities.Products.Select(x => new ProductInfo
            {
                Name = x.Name,
                ProductID = x.ProductID,
                ProductNumber = x.ProductNumber
            });

            return query.ToArray();
        }

        public Product GetProduct(int id)
        {
            return _entities.Products.FirstOrDefault(x => x.ProductID == id).ToProduct();
        }

        public void Create(Product product)
        {
            _entities.Products.Add(product.ToDbProduct());

            _entities.SaveChanges();
        }

        public void Edit(Product product)
        {
            var toUpdate = _entities.Products.First(x => product.ProductID == x.ProductID);

            toUpdate.Class = product.Class;
            toUpdate.Color = product.Color;
            toUpdate.DaysToManufacture = product.DaysToManufacture;
            toUpdate.FinishedGoodsFlag = product.FinishedGoodsFlag;
            toUpdate.ListPrice = product.ListPrice;
            toUpdate.MakeFlag = product.MakeFlag;
            toUpdate.ModifiedDate = product.ModifiedDate;
            toUpdate.Name = product.Name;
            toUpdate.ProductLine = product.ProductLine;
            toUpdate.ProductNumber = product.ProductNumber;
            toUpdate.ReorderPoint = product.ReorderPoint;
            toUpdate.rowguid = product.rowguid;
            toUpdate.SafetyStockLevel = product.SafetyStockLevel;
            toUpdate.SellStartDate = product.SellStartDate;
            toUpdate.Size = product.Size;
            toUpdate.SizeUnitMeasureCode = product.SizeUnitMeasureCode;
            toUpdate.StandardCost = product.StandardCost;
            toUpdate.Style = product.Style;
            toUpdate.WeightUnitMeasureCode = product.WeightUnitMeasureCode;

            _entities.SaveChanges();
        }

        public bool Delete(int id)
        {
            var removed = _entities.Products.Remove(_entities.Products.First(x => x.ProductID == id));
            _entities.SaveChanges();

            return removed != null;
        }
    }
}
