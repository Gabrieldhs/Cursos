﻿using Microsoft.AspNetCore.Mvc;

namespace FastTech.Web.Controllers;

[ApiController]
public abstract class MainController : ControllerBase
{
    public MainController()
    {

    }

    protected ActionResult CustomResponse(object result = null)
    {
        return Ok(new
        {
            sucess = true,
            data = result,
        });
    }
}