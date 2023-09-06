using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LILO_Packager.v2.shared
{
    public class GuidUtility
    {
        public static Guid CreateGuidForSession(DateTime sessionDateTime, string sessionId, string userId, string userRights)
        {
            long timestampTicks = sessionDateTime.Ticks;

            byte[] sessionIdBytes = Encoding.UTF8.GetBytes(sessionId);
            byte[] userIdBytes = Encoding.UTF8.GetBytes(userId);
            byte[] userRightsBytes = Encoding.UTF8.GetBytes(userRights);

            byte[] sessionBytes = new byte[32];

            BitConverter.GetBytes(timestampTicks).CopyTo(sessionBytes, 0);

            Array.Copy(sessionIdBytes, 0, sessionBytes, 8, Math.Min(sessionIdBytes.Length, 8));

            Array.Copy(userIdBytes, 0, sessionBytes, 16, Math.Min(userIdBytes.Length, 8));

            Array.Copy(userRightsBytes, 0, sessionBytes, 24, Math.Min(userRightsBytes.Length, 8));

            return new Guid(sessionBytes);
        }

        public static (DateTime, string, string, string) ExtractSessionInfoFromGuid(Guid guid)
        {
            byte[] sessionBytes = guid.ToByteArray();

            long timestampTicks = BitConverter.ToInt64(sessionBytes, 0);

            byte[] sessionIdBytes = new byte[8];
            Array.Copy(sessionBytes, 8, sessionIdBytes, 0, 8);
            string sessionId = Encoding.UTF8.GetString(sessionIdBytes).TrimEnd('\0');

            byte[] userIdBytes = new byte[8];
            Array.Copy(sessionBytes, 16, userIdBytes, 0, 8);
            string userId = Encoding.UTF8.GetString(userIdBytes).TrimEnd('\0');

            byte[] userRightsBytes = new byte[8];
            Array.Copy(sessionBytes, 24, userRightsBytes, 0, 8);
            string userRights = Encoding.UTF8.GetString(userRightsBytes).TrimEnd('\0');

            DateTime sessionDateTime = new DateTime(timestampTicks);

            return (sessionDateTime, sessionId, userId, userRights);
        }
    }

}

