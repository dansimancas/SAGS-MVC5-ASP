using System;
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
    
        public long Identification
        {
            get { return identification; }
            set { identification = value; }
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
        }

        public Teen(string name, string lastname, string gender, string address, string city, List<long> tels, int doc)
        {
            this.id = ++val;
            this.name = name;
            this.lastname = lastname;
            this.gender = gender;
            this.address = address;
            this.city = city;
            this.telephones = tels;
            this.documentTypeID = doc;
        }

        #endregion

        #region Methods

        public void addTelephone(long t)
        {
            telephones.Add(t);
        }

        public string printTelephones(List<long> l)
        {
            string value = "";
            foreach (long o in l)
            {
                value += o + ", ";
            }
            return value.Substring(0, value.Length - 2);
        }
        
        #endregion
    }
}
