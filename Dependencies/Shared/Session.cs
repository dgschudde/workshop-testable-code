namespace TestableCodeDemos.Dependencies.Shared
{
    public class Session : ISession
    {
        private readonly Login _login;

        public Session(Login login)
        {
            _login = login;
        }

        public Login GetLogin()
        {
            return _login;
        }
    }
}
