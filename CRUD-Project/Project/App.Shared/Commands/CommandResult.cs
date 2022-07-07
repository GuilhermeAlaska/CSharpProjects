namespace App.Shared.Commands
{
    public class CommandResult
    {
        public CommandResult(Result result)
        {
            Result = result;
        }

        public Result Result { get; set; }
    }
}