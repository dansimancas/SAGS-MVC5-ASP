using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    interface Member
    {
        string Id { get; set; }
        string Name { get; set; }
        string Lastname { get; set; }
        string Gender { get; set; }
        string Address { get; set; }
        string City { get; set; }
        long Telephone { get; set; }
        long Identification { get; set; }
        long DocumentType { get; set; }

    }
}
