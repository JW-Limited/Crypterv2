using System.Security.Cryptography;

namespace LILO_Packager.v2.Core.Keys.Types
{
    public class Salt
    {
        private readonly byte[] _bytes;

        public Salt()
        {
            _bytes = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(_bytes);
            }
        }

        public byte[] Bytes
        {
            get { return _bytes; }
        }

        public override string ToString()
        {
            return Convert.ToBase64String(_bytes);
        }
    }

}
