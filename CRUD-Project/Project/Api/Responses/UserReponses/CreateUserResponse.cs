using App.Shared.Commands;

namespace App.Api.Responses.UserReponses
{
    public class CreateUserResponse : CommandResult
    {
        public CreateUserResponse(Result result) : base(result)
        {
        }
    }
}