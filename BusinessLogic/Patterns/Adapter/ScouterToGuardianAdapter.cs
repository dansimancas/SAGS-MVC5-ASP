﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ScouterToGuardianAdapter : Guardian
    {
        #region Atributes

        private Scouter scouterInstance;

        #endregion

        #region Constructors

        public ScouterToGuardianAdapter()
        {

        }

        public ScouterToGuardianAdapter(Scouter s)
        {
            scouterInstance = s;
            base.Name = s.Name;
            base.Lastname = s.Lastname;
            base.GenderMember = s.GenderMember;
            base.Address = s.Address;
            base.City = s.City;
            base.Telephones = s.Telephones;
            base.EmailAddresses = s.EmailAddresses;
            base.Document = s.Document;
            base.Identification = s.Identification;
        }

        #endregion
    }
}
