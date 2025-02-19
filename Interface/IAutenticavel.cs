using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrocas.Interface {
    internal interface  IAutenticavel {
        bool Autenticar(string usarname, string password);

    }
}
