﻿using System.Net;
using eProdaja.WebAPI.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace eProdaja.WebAPI.Filters
{
    public class ErrorFilter:ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            if (context.Exception is UserException)
            {
                context.ModelState.AddModelError("ERROR",context.Exception.Message);
                context.HttpContext.Response.StatusCode=(int)HttpStatusCode.BadRequest;
            }
            else
            {
                context.ModelState.AddModelError("ERROR","Greska na serveru");
                context.HttpContext.Response.StatusCode = (int) HttpStatusCode.InternalServerError;
            }


            context.Result=new JsonResult(context.ModelState);
        }
    }
}