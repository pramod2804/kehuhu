using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    interface ICyberArkIntegration
    {
        //Before calling CyberArk API check if the password is stroed  in cahce
        string GetPasswordFromCache(string userId);
        void StorePasswordToCache(string userId, string password);
        string GetPasswordFromVault(string userId);

    }
}
