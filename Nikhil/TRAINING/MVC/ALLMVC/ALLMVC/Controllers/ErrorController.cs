using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ALLMVC.Controllers
{
    public class ErrorController : Controller
    {
        private readonly ILogger<ErrorController> logger;

        public ErrorController(ILogger<ErrorController> logger)
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
        }
        public IActionResult Index()
        {
            var execeptoions = HttpContext.Features.Get<IExceptionHandlerPathFeature>();

            logger.LogError($"The path {execeptoions.Path} throw an exeption" + $" {execeptoions.Error}");
            //ViewBag.ExceptionPath = execeptoions.Path;
            //ViewBag.ExeptionMessage = execeptoions.Error.Message;
            //ViewBag.Stacktrace = execeptoions.Error.StackTrace;
            return View("Index");
        }

        public IActionResult HttpStatusCodeHandler(int StatusCode)
        {
            var StatusCodeResult = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();

            switch (StatusCode)
            {
                case 404:
                    ViewBag.ErrorMesage = "Sorry";
                    logger.LogWarning($"404 Error occured path = {StatusCodeResult.OriginalPath}" + $"and QueryString = {StatusCodeResult.OriginalPath}");
                    break;
            };
            return View();
        }
    }
}
