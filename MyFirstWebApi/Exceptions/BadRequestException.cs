namespace MyFirstWebApi.Exceptions
{
    public class BadRequestException : Exception
    {
        public BadRequestException(string message) : base(message) 
        {

        }
    }
}
