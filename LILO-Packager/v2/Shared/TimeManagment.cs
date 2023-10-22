using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LILO_Packager.v2.Shared
{
    namespace LILO_Packager.v2.Shared
    {
        public class TimeManagment
        {
            DateTimeOffset utcStart = TimeProvider.System.GetUtcNow();
            DateTimeOffset localStart = TimeProvider.System.GetLocalNow();

            private class ZonedTimeProvider : TimeProvider
            {
                private TimeZoneInfo _zoneInfo;

                public ZonedTimeProvider(TimeZoneInfo zoneInfo) : base()
                {
                    _zoneInfo = zoneInfo ?? TimeZoneInfo.Local;
                }

                public override TimeZoneInfo LocalTimeZone => _zoneInfo;

                public static TimeProvider FromLocalTimeZone(TimeZoneInfo zoneInfo) =>
                    new ZonedTimeProvider(zoneInfo);
            }

            ITimer timer = TimeProvider.System.CreateTimer((s) =>
            {
                var utcNow = TimeProvider.System.GetUtcNow();
                var localNow = TimeProvider.System.GetLocalNow();

            }, null, TimeSpan.Zero, Timeout.InfiniteTimeSpan);

        }
    }

}
