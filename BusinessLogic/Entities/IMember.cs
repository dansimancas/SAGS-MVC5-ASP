using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    interface IMember : IObserver
    {

        #region Properties

        int Id { get; }
        string Name { get; set; }
        string Lastname { get; set; }
        string Gender { get; set; }
        string Address { get; set; }
        string City { get; set; }
        List<long> Telephones { get; set; }
        List<string> EmailAddresses { get; set; }
        int DocumentTypeID { get; set; }
        long Identification { get; set; }

        #endregion

        #region Methods

        void addTelephone(long t);
        void addEmailAddress(string e);
        //protected string printTelephones(List<long> l);
        
        #endregion
    }
}
