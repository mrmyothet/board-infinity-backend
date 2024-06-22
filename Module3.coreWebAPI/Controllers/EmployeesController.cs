using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Module3.coreWebAPI.Controllers;

// Attribute Routing examples

//[Route("api/[controller]")]
[ApiController]
public class EmployeesController : ControllerBase
{
    [HttpGet]
    [Route("employees/all")]
    public string GetAllEmployees()
    {
        return "All employees here";
    }

    [HttpGet]
    [Route("employees/{id}")]
    public string GetEmployeeById(int id)
    {
        return "Employee By Id: " + id;
    }

    [HttpGet]
    [Route("details/{id:int:min(100)}")]
    public string GetEmployeeDetails(int id)
    {
        return "Employee Details for Id: " + id;
    }

    [HttpGet]
    [Route("details/{name:alpha}")]
    public string GetEmployeeDetails(string name)
    {
        return "Employee Details for Name: " + name;
    }
}
