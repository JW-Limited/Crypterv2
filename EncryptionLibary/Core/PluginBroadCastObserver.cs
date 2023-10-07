using LILO_Packager.v2.Shared.Api.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionLibary.Core
{
    public class PluginBroadCastObserver : IObserver<BroadcastMessage>
    {
        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(BroadcastMessage value)
        {
            throw new NotImplementedException();
        }
    }
}
