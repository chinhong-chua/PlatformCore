using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using PlatformDemo2.Controllers;

namespace PlatformDemo2.Filters
{
    public class Ticket_EnsureEnteredDAte : ActionFilterAttribute
    {
        // public override void OnActionExecuting(ActionExecutingContext context)
        // {
        //     base.OnActionExecuting(context);
        //     var ticket = context.ActionArguments["ticket"] as Ticket ;
        //     if(ticket != null && !string.IsNullOrWhiteSpace(ticket.Owner) && ticket.EnteredDate.HasValue == false){
        //             context.ModelState.AddModelError("EnteredDate", "EnteredDate is required");
        //             context.Result= new BadRequestObjectResult(context.ModelState);
        //     }
        // }
 public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
 
            var ticket = context.ActionArguments["ticket"] as Ticket;
            if (ticket != null && 
                !string.IsNullOrWhiteSpace(ticket.Owner) &&
                ticket.EnteredDate.HasValue == false)
            {
                context.ModelState.AddModelError("EnteredDate", "EnteredDate is required.");
                var problemDetails = new ValidationProblemDetails(context.ModelState)
                {
                    Status = StatusCodes.Status400BadRequest,
                };
                context.Result = new BadRequestObjectResult(problemDetails);
            }
        }

    }
}