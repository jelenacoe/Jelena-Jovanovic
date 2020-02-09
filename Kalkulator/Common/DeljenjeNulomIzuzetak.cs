using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [DataContract]
    public class DeljenjeNulomIzuzetak
    {
        private string razlog;

        public DeljenjeNulomIzuzetak()
        {
            razlog = "Ne mozete deliti sa nulom";
        }

        [DataMember]
        public string Razlog
        {
            get
            {
                return razlog;
            }
            set
            {
                razlog = value;
            }
        }

    }
}
