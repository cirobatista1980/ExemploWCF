using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wcf
{
    public class Service : IService
    {
        public string GetNome()
        {
            return "Nome";
        }

        public int Soma()
        {
            return 5;
        }
    }
}
