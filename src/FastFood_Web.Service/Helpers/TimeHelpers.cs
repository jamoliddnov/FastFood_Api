using FastFood_Web.Domain.Constans;

namespace FastFood_Web.Service.Helpers
{
    public class TimeHelpers
    {
        public static DateTime GetCurrentServerTime()
        {
            return DateTime.UtcNow.AddHours(TimeConstans.UTC);

        }
    }
}


