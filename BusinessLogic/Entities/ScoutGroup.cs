using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLogic
{
    [Table("Scout Group")]
    public class ScoutGroup
    {
        #region Atributes
        private int id;
        private static ScoutGroup scoutGroupInstance;

        #endregion

        #region Properties

        [Key]
        public int Id
        {
            get { return id; }
            set { id = 0; }
        }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Number { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public List<long> Telephones { get; set; }

        [Required]
        public string Sponsor { get; set; }

        #endregion

        #region Constructors

        public ScoutGroup()
        {
            this.Id = 0;
            this.Name = "Los caminantes";
            this.Number = 123;
            this.State = "Bolívar";
            this.City = "Cartagena";
            this.Country = "Colombia";
            this.Address = "Manga";
            this.Telephones = new List<long>() { 6565656, 3171526390 };
            this.Sponsor = "Ángel Jiménez";

        }

        public ScoutGroup(string name, int number, string state, string city, string country, string address, List<long> tels, string sponsor)
        {
            this.Id = 0;
            this.Name = name;
            this.Number = number;
            this.State = state;
            this.City = city;
            this.Country = country;
            this.Address = address;
            this.Telephones = (tels != null) ? tels : new List<long>();
            this.Sponsor = sponsor;
        }
        #endregion

        #region Methods
        public static ScoutGroup getInstance()
        {
            if (scoutGroupInstance == null)
                scoutGroupInstance = new ScoutGroup();
            return scoutGroupInstance;
        }

        public void editScoutGroupData(string name, int number, string city, string state, string country, string address, string sponsor)
        {
            scoutGroupInstance.Name = name;
            scoutGroupInstance.Number = number;
            scoutGroupInstance.City = city;
            scoutGroupInstance.State = state;
            scoutGroupInstance.Country = country;
            scoutGroupInstance.Address = address;
            scoutGroupInstance.Sponsor = sponsor;
        }

        public string printTelephoneList(List<long> tels)
        {
            string result = "";
            if (tels != null && tels.Count > 0)
            {
                foreach (long l in tels)
                {
                    result += l + ", ";
                }
                return result.Substring(0, result.Length - 2);
            }
            else return "There are no telephone numbers asigned yet.";
        }

        #endregion

        #region Overwritten methods

        public override string ToString()
        {
            return "\nScout Group: \nId: " + scoutGroupInstance.Id +
                "\nName: " + scoutGroupInstance.Name +
                "\nNumber: " + scoutGroupInstance.Number +
                "\nCity: " + scoutGroupInstance.City +
                "\nState: " + scoutGroupInstance.State +
                "\nCountry: " + scoutGroupInstance.Country +
                "\nAddress: " + scoutGroupInstance.Address +
                "\nTelephones: " + printTelephoneList(scoutGroupInstance.Telephones) +
                "\nSponsor: " + scoutGroupInstance.Sponsor;
        }

        #endregion
    }
}
