using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace PlatformDemo2.Filters
{
    public class Version1_DiscontinueResourceFilter : Attribute, IResourceFilter
    {
        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
           if(!context.HttpContext.Request.Path.Value.ToLower().Contains("v2")){
               context.Result = new BadRequestObjectResult(
                   new{
                   Versioning = new []{"This version of API has expired, please update to latest."}
               });
           }
        }
    }
}