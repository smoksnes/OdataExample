using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using WebApplication1.Models;

namespace WebApplication1.Controllers;


[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
    private readonly MyContext _context;

    public CustomerController(MyContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Get(ODataQueryOptions<Customer> queryOptions)
    {
        var querable = _context.Customers;
        var finalQuery = queryOptions.ApplyTo(querable);
        return Ok(finalQuery);
    }

}