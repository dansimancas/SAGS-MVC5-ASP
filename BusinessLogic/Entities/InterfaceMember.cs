﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    interface InterfaceMember
    {

        #region Properties

        string Id { get; }
        string Name { get; set; }
        string Lastname { get; set; }
        string Gender { get; set; }
        string Address { get; set; }
        string City { get; set; }
        List<long> Telephones { get; set; }
        string DocumentTypeID { get; set; }
        long Identification { get; set; }

        #endregion
    }
}
