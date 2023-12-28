namespace Bookify.Api.Controllers.Apartments;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Bookify.Application.Apartments.SearchApartments;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

[ApiController]
[Route("[controller]")]
public class ApartmentsController : ControllerBase
{
    private readonly ILogger<ApartmentsController> _logger;
    private readonly ISender _sender;

    public ApartmentsController(ILogger<ApartmentsController> logger, ISender sender)
    {
        _logger = logger;
        _sender = sender;
    }

    [HttpGet]
    public async Task<IActionResult> SearchApartments(DateOnly startDate, DateOnly endDate, CancellationToken cancellationToken)
    {
        SearchApartmentsQuery? query = new(startDate, endDate);
        var result = await _sender.Send(query);

        return Ok(result.Value);
    }
}
