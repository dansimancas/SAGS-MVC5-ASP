﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Scouter : Member
    {
        #region Atributes

        private string id;
        private string name;
        private string lastname;
        private string gender;
        private string address;
        private string city;
        private long telephone;
        private long identification;
        private long documentType;
        private List<string> guardiansId;
        private string medicalHistoryId;

        #endregion

        #region Properties

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public long Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }
        public long Identification
        {
            get { return identification; }
            set { identification = value; }
        }
        public long DocumentType
        {
            get { return documentType; }
            set { documentType = value; }
        }
        public List<string> GuardiansId
        {
            get { return guardiansId; }
            set { guardiansId = value; }
        }
        public string MedicalHistoryId
        {
            get { return medicalHistoryId; }
            set { medicalHistoryId = value; }
        }

        #endregion

        #region Constructors

        public Scouter(string id, string name, string lastname, string gender, string address, string city, long tel, long doc, List<string> guard, string med)
        {
            this.id = id;
            this.name = name;
            this.lastname = lastname;
            this.gender = gender;
            this.address = address;
            this.city = city;
            this.telephone = tel;
            this.documentType = doc;
            this.guardiansId = guard;
            this.medicalHistoryId = med;
        }

        public Scouter(string id, string name, string lastname, string gender, string address, string city, long tel, long doc, string med)
        {
            this.id = id;
            this.name = name;
            this.lastname = lastname;
            this.gender = gender;
            this.address = address;
            this.city = city;
            this.telephone = tel;
            this.documentType = doc;
            this.medicalHistoryId = med;
        }

        #endregion

        #region Methods
        
        public void addGuardian(string guardianId)
        {
            this.guardiansId.Add(guardianId);
        }

        #endregion
    }
}
