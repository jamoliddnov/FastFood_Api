namespace FastFood_Web.Domain.Common
{
    public class Base
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
    }
}
