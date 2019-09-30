using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Signal_R_Hub
{
    public interface ITypedHubClient
    {
        Task BroadcastMessage(string type, string payload);
    }
}
