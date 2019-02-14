using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System;

namespace Common
{
    public class ApiExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            if (context.Exception is ArgumentException)
            {
                var obj = JsonConvert.SerializeObject(new { error = context.Exception.Message });
                context.ExceptionHandled = true;
                context.Result = new BadRequestObjectResult(obj);
            }
        }
    }
}
