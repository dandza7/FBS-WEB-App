using FBSApp.SupportClasses.GlobalExceptionHandler.CustomExceptions;
using System.Net;

namespace FBSApp.SupportClasses.GlobalExceptionHandler
{
    public class ExceptionsDictionary
    {
        private static Dictionary<Type, HttpStatusCode> exceptionStatusCodes = new Dictionary<Type, HttpStatusCode>
        {
            {typeof(Exception), HttpStatusCode.InternalServerError},
            {typeof(NotFoundException), HttpStatusCode.NotFound},
            {typeof(BadCredentialsException), HttpStatusCode.BadRequest},
            {typeof(DuplicateItemException), HttpStatusCode.BadRequest}
        };
        public static Type[] BadRequestExceptions =
        {
            typeof(BadCredentialsException),
            typeof(NotFoundException),
            typeof(DuplicateItemException)
        };

        public static HttpStatusCode GetExceptionStatusCode(Exception ex)
        {
            bool exceptionFound = exceptionStatusCodes.TryGetValue(ex.GetType(), out var statusCode);
            return exceptionFound ? statusCode : HttpStatusCode.InternalServerError;
        }
    }
}
