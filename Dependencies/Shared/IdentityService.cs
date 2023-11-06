namespace TestableCodeDemos.Dependencies.Shared
{
    public class IdentityService : IIdentityService
    {
        public string GetUserName()
        {
            throw new NotImplementedException();
        }
    }
}
