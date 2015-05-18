using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ScoutGroup
    {
        #region Atributes

        private static ScoutGroup group;
        List<EducationalSection> sections = new List<EducationalSection>();
        private string id;
        private string name;
        private string country;
        private string city;
        private string address;
        private string sponsor;

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
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Sponsor
        {
            get { return sponsor; }
            set { sponsor = value; }
        }

        #endregion

        #region Methods

        public static ScoutGroup getInstance()
        {
            if (group == null)
                group = new ScoutGroup();
            return group;
        }
        public void addSection(EducationalSection s)
        {
            sections.Add(s);
        }
        public List<EducationalSection> getSection()
        {
            return sections;
        }

        #endregion

        #region Overwritten methods

        public override string ToString()
        {
            return "\nScout Group:\nId: " + group.id +
                "\nName: " + group.name +
                "\nCountry: " + group.country +
                "\nCity: " + group.city +
                "\nAddress: " + group.address +
                "\nSponsor: " + group.sponsor;
        }
        
        #endregion
    }
}
