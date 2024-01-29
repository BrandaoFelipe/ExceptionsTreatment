using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Treatment.Entitites.Exceptions
{
    internal class DomainException : ApplicationException //DOMAIN EXCEPTION FOI CRIADO PRA HERDAR DO APPLICATION EXCEPTION
    {
        public DomainException(string message) : base(message) //O "STRING MESSAGE ESTÁ RECEBENDO O MESSAGE
                                                               //DO PROGRAMA "BASE", OU SEJA, O STRING MESSAGE ESTÁ HERDANDO
                                                               //O MESSAGE DO APPLICATION EXCEPTION
        {

        }
    }
}
