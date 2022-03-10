using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;

namespace WebApplication1.Models;

public static class EdmModel
{
    public static IEdmModel GetConventionModel()
    {
        var builder = new ODataConventionModelBuilder();
        builder.EntitySet<Customer>("Customers");
        return builder.GetEdmModel();
    }
}