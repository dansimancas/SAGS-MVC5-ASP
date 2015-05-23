﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Teen : InterfaceMember
    {
        #region Atributes

        private int id;
        private string name;
        private string lastname;
        private string gender;
        private string address;
        private string city;
        private List<long> telephones;
        private int documentTypeID;
        private long identification;
        private List<string> guardiansId;
        private MedicalHistory medicalHistory;
        private static int val = 0;

        #endregion

        #region Properties

        public int Id
        {
            get { return id; }
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

        public List<long> Telephones
        {
            get { return telephones; }
            set { telephones = value; }
        }

        public int DocumentTypeID
        {
            get { return documentTypeID; }
            set { documentTypeID = value; }
        }
    
        public long Identification
        {
            get { return identification; }
            set { identification = value; }
        }

        public List<string> GuardiansId
        {
            get { return guardiansId; }
            set { guardiansId = value; }
        }

        public MedicalHistory MedicalHistoryId
        {
            get { return medicalHistory; }
        }

        #endregion

        #region Constructors

        public Teen()
        {
            this.id = ++val;
            this.name = "Laura Cristina";
            this.lastname = "Schiatti Sisó";
            this.gender = "Female";
            this.address = "Manga";
            this.city = "Cartagena";
            this.telephones = new List<long>();
            this.documentTypeID = 1234;
            this.identification = 1050962143;
            this.medicalHistory = new MedicalHistory(this.id);
        }

        public Teen(string name, string lastname, string gender, string address, string city, List<long> tels, int doc, long id, List<string> guardians, MedicalHistory med)
        {
            this.id = ++val;
            this.name = name;
            this.lastname = lastname;
            this.gender = gender;
            this.address = address;
            this.city = city;
            this.telephones = tels;
            this.documentTypeID = doc;
            this.identification = id;
            this.guardiansId = guardians;
            //Ensuring that the medical history is his/her own.
            this.medicalHistory = (med.MemberId == this.id) ? med : new MedicalHistory(this.id);
        }

        public Teen(string name, string lastname, string gender, string address, string city, List<long> tels, int doc, long id, List<string> guardians)
        {
            this.id = ++val;
            this.name = name;
            this.lastname = lastname;
            this.gender = gender;
            this.address = address;
            this.city = city;
            this.telephones = tels;
            this.documentTypeID = doc;
            this.identification = id;
            this.guardiansId = guardians;
            this.medicalHistory = new MedicalHistory(this.id);
        }

        #endregion

        #region Methods

        public void addTelephone(long t)
        {
            telephones.Add(t);
        }

        protected string printTelephones(List<long> tels)
        {
            if (tels != null && tels.Count > 0)
            {
                string value = "";
                foreach (long o in tels)
                {
                    value += o + ", ";
                }
                return value.Substring(0, value.Length - 2);
            }
            else return "There are no telephone numbers asigned yet.";
        }

        protected string printStringList(List<string> mylist)
        {
            if (mylist != null && mylist.Count > 0)
            {
                string value = "";
                foreach (string s in mylist)
                {
                    value += s + ", ";
                }
                return value.Substring(0, value.Length - 2);
            }
            else return "There are no elements asigned yet.";
        }
        
        #endregion

        #region Overridden methods

        public override string ToString()
        {
            return "\nTeen:\nId: " + this.id +
                "\nName: " + this.name +
                "\nLast name: " + this.gender +
                "\nAddress: " + this.address +
                "\nCity: " + this.city +
                "\nTelephones: " + printTelephones(telephones) +
                "\nDocument type: " + this.documentTypeID +
                "\nIdentification: " + this.identification +
                "\nGuardians : " + printStringList(guardiansId) +
                "\nMedical History ID: " + this.medicalHistory.Id;
        }

        #endregion

    }
}
