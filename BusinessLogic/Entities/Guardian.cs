using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Guardian : InterfaceMember
    {
        #region Atributes

        //TODO Agregar atributos propios de los guardianes.

        private int id;
        private string name;
        private string lastname;
        private string gender;
        private string address;
        private string city;
        private List<long> telephones;
        private int documentTypeID;
        private long identification;
        private static int val;

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

        public Guardian()
        {
            this.id = ++val;
            this.name = "Daniela";
            this.lastname = "Simancas Mateus";
            this.gender = "Femenine";
            this.address = "Torices";
            this.city = "Cartagena";
            this.telephones = new List<long>();
            this.documentTypeID = 1;
            this.identification = 1050692143;
        }

        public Guardian(string name, string lastname, string gender, string address, string city, List<long> tel, int doc, long ident)
        {
            this.id = ++val;
            this.name = name;
            this.lastname = lastname;
            this.gender = gender;
            this.address = address;
            this.city = city;
            this.telephones = tel;
            this.documentTypeID = doc;
            this.identification = ident;
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
                value += o+", ";
            }
            return value.Substring(0, value.Length - 2);
        }

        #endregion

        #region Overwritten methods

        //TODO Cambiar document type ID por document type Name
        public override string ToString()
        {
            return "\nGuardian:\nId: " + this.id +
                "\nName: " + this.name +
                "\nLast name: " + this.gender +
                "\nAddress: " + this.address +
                "\nCity: " + this.city +
                "\nTelephones: " + printTelephones(telephones) +
                "\nDocument type: " + this.documentTypeID +
                "\nIdentification: " + this.identification;
        }

        #endregion

    }
}
