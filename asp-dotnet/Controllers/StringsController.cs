using Microsoft.AspNetCore.Mvc;
using MyWebApplication.Abstraction;
using MyWebApplication.Dto;
using MyWebApplication.Repositories;
using MyWebApplication.Services;

namespace MyWebApplication.Controllers;

[ApiController]
[Route("[controller]")]
public class StringsController : ControllerBase
{
    private readonly IRequestCounter _counter;

    public StringsController(IRequestCounter counter)
    {
        _counter = counter;
    }
    
    [HttpGet]
    public IActionResult Get()
    {
        _counter.Increment();
        
        var items = StringRepository.GetAllItems();
        return Ok($"{items}\nRequest Counter: {_counter.GetCount()}");
    }
    
    [HttpPost]
    public IActionResult Post([FromBody] StringRequest request)
    { 
        _counter.Increment();
        
        var value = request.Value;
        
        if (string.IsNullOrWhiteSpace(value))
        {
            return BadRequest($"Строка не может быть пустой.\nRequest Counter: {_counter.GetCount()}");
        }

        StringRepository.AddItem(value);
        return Ok($"Добавлено: {value}\nRequest Counter: {_counter.GetCount()}");
    }
}
