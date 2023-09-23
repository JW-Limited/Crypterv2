using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LILO_Packager.v2.Core.Interfaces
{
    public interface IMediaService
    {
        Task<bool> PlayAsync();
        Task<bool> PauseAsync();
        Task<int> GetCurrentPositionAsync();
        Task<int> GetDurationAsync();
    }
}
