using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using PlatformDemo2.Controllers;

namespace PlatformDemo2.Filters
{
    public class Ticket_EnsureEnteredDateEarlierThanDueDate: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
            var ticket = context.ActionArguments["ticket"] as Ticket;
            if(ticket != null && ticket.DueDate < ticket.EnteredDate){
                context.ModelState.AddModelError("EnteredDate","Entered Date has to be earlier than Due Date");
                var problemDetails = new ValidationProblemDetails(context.ModelState){
                    Status= StatusCodes.Status400BadRequest
                };
                context.Result= new BadRequestObjectResult(problemDetails);
            }
        }
    }
}