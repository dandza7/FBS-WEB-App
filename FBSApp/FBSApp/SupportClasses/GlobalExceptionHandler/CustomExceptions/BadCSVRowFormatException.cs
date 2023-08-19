namespace FBSApp.SupportClasses.GlobalExceptionHandler.CustomExceptions
{
    public class BadCSVRowFormatException : Exception
    {
        public BadCSVRowFormatException(string message = "Bad CSV Row format!") : base(message)
        { }
    }
}
