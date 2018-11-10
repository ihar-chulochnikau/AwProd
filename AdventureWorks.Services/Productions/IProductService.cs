using System.Collections.Generic;

namespace AdventureWorks.Services.Productions
{
    public interface IProductService
    {
        ICollection<ProductInfo> GetProductInfos();

        Product GetProduct(int id);

        bool Delete(int id);

        void Create(Product product);

        void Edit(Product product);
    }
}