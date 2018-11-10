using AdventureWorks.Services.Productions;
using Swashbuckle.Swagger;
using System;

namespace AW_Production.Filters
{
    public class ProductFilter : ISchemaFilter
    {
        public void Apply(Schema schema, SchemaRegistry schemaRegistry, Type type)
        {
            if (type == typeof(Product))
            {
                schema.example = Product.New();
            }
        }
    }
}