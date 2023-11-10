using System.Net.NetworkInformation;
using Microsoft.AspNetCore.Mvc;

namespace BuberBreakfast.Controllers;

public class ErrorController : ControllerBase
{
    [Route("/error")]
    public IActionResult Error()
    {
        return Problem();
    }
}