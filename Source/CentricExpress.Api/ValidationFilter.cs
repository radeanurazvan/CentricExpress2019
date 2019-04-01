using CentricExpress.Business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CentricExpress.Api
{
    public class ValidationFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if (context.Exception is BusinessException exception)
            {
                context.Result = new BadRequestObjectResult(exception.Error);
            }
        }
    }
}