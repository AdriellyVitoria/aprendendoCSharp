﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UsuarioApi.Controllers;

[ApiController]
[Route("[Controller]")]
public class AcessoController : ControllerBase
{
    [HttpGet]
    [Authorize(Policy = "IdadeMionima")]
    public IActionResult Get()
    {
        return Ok("Acesso permitido");
    }
   
   
}
