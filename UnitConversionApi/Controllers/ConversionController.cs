using Microsoft.AspNetCore.Mvc;
using UnitConversionApi.Interfaces;
using UnitConversionApi.Models;

namespace UnitConversionApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ConversionController : ControllerBase
{
    private readonly IConversionService _conversionService;

    public ConversionController(IConversionService conversionService)
    {
        _conversionService = conversionService;
    }

    [HttpPost("convert")]
    public IActionResult Convert(ConversionRequest request)
    {
        var response = _conversionService.Convert(request);

        return Ok(response);
    }
}
