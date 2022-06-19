using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.Clases
{
    class Empresa
    {
        private string name;
        private string email;
        private string rfc;
        private static int countEnterprises =  0;

        public Empresa(string _name, string _email, string _rfc)
        {
            name = _name;
            email = _email;
            rfc = _rfc;
            countEnterprises += 1;
            Console.WriteLine("Empresas: " + countEnterprises);
        }

        public Empresa() { }

        public string GetName()
        {
            return name;
        }

        public string GetEmail()
        {
            return email;
        }

        public string GetRfc()
        {
            return rfc;
        }

        public int GetCount()
        {
            return countEnterprises;
        }
    }
}
