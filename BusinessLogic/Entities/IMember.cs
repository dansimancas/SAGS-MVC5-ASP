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
        string Telephones { get; set; }
        string EmailAddresses { get; set; }
        DocumentType Document { get; set; }
        long Identification { get; set; }

        #endregion
    }
}
