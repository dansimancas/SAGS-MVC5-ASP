using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    interface Member
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public long Telephone { get; set; }
        public long Identification { get; set; }
        public long DocumentType { get; set; }
        public List<string> GuardiansId { get; set; }
        public string MedicalHistoryId { get; set; }

    }
}
