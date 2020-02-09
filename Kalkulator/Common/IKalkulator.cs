using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common

{   [ServiceContract]
    public interface IKalkulator
    {
        [OperationContract]
        KompleksanBroj Saberi(KompleksanBroj a, KompleksanBroj b);

        [OperationContract]
        KompleksanBroj Oduzmi(KompleksanBroj a, KompleksanBroj b);

        [OperationContract]
        KompleksanBroj Pomnozi(KompleksanBroj a, KompleksanBroj b);

        [OperationContract]
        [FaultContract(typeof(DeljenjeNulomIzuzetak))]
        KompleksanBroj Podeli(KompleksanBroj a, KompleksanBroj b);

    }
}
