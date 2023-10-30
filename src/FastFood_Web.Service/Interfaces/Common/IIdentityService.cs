namespace FastFood_Web.Service.Interfaces.Common
{
    public interface IIdentityService
    {
        public string Id { get; }
        public string Email { get; }
        public string UserRole { get; }
    }
}
