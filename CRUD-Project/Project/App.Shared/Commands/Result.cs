namespace App.Shared.Commands
{
    public class Result
    {
        public object? Data { get; set; }
        public string[]? ErrorMessages { get; set; }
        public EStatusCode StatusCode { get; set; }
    }
}