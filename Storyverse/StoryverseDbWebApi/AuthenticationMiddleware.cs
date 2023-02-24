namespace StoryverseDbWebApi;

public static class AuthenticationMiddleware
{
    public static Func<HttpContext, RequestDelegate, Task> Authenticate()
    {
        return async (context, next) =>
        {
            const string bearerToken = "Bearer:dsajifh8whfuihwauiefh23iuhf9uSHFIUHW49783HFPUIwfw8934hP9FIZ";

            var header = context.Request.Headers;
        
            header.TryGetValue("Authorization", out var token);

            if (token != bearerToken)
            {
                context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                await context.Response.WriteAsync("Request is unauthorized.");
                return;
            }
        
            await next.Invoke(context);
        };
    }
}