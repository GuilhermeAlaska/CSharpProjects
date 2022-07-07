namespace App.Shared.Commands
{
    public enum EStatusCode
    {
        Ok = 200,
        Created = 201,
        NoContent = 204,
        BadRequest = 400,
        Forbidden = 403,
        NotFound = 404,
        InternalError = 500
    }
}