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

        private string id;
        private string name;
        private string lastname;
        private string gender;
        private string address;
        private string city;
        private List<long> telephones;
        private string documentTypeID;
        private long identification;

        #endregion

        #region Properties

        public string Id
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

        public string DocumentTypeID
        {
            get { return documentTypeID; }
            set { documentTypeID = value; }
        }

        #endregion

        #region Constructors

        public Teen()
        {
            this.id = Guid.NewGuid().ToString();
        }

        public Teen(string name, string lastname, string gender, string address, string city, List<long> tels, string doc)
        {
            this.id = Guid.NewGuid().ToString();
            this.name = name;
            this.lastname = lastname;
            this.gender = gender;
            this.address = address;
            this.city = city;
            this.telephones = tels;
            this.documentTypeID = doc;
        }

        #endregion


        
    }
}
