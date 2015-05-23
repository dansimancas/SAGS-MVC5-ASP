using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Properties;

namespace BusinessLogic
{
    public class ScoutGroup
    {
        #region Atributes
        private static ScoutGroup instance;
        private string name;
        private int number;
        private string city;
        private string state;
        private string country;
        private string address;
        private List<long> telephone;
        private string sponsor;
        #endregion

        #region Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public string State
        {
            get { return state; }
            set { state = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public List<long> Telephone
        {
            get { return telephone; }
            set { telephone = value; }
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
            if (instance == null)
                instance = new ScoutGroup();
            return instance;
        }
        #endregion

        #region Constructor
        public ScoutGroup()
        {
            try
            {
                this.name = Settings.Default["name"].ToString();
            }
            catch (Exception)
            {
                this.name = "";
                
            }

            try
            {
                this.number = Convert.ToInt32(Settings.Default["number"].ToString());
            }
            catch (Exception)
            {

                this.number = 0;
            }

            try
            {
                this.city = Settings.Default["city"].ToString();
            }
            catch (Exception)
            {

                this.city = "";
            }

            try
            {
                this.state = Settings.Default["state"].ToString();
            }
            catch (Exception)
            {

                this.state = "";
            }

            try
            {
                this.country = Settings.Default["country"].ToString();
            }
            catch (Exception)
            {

                this.country = "";
            }


            try
            {
                this.address = Settings.Default["address"].ToString();
            }
            catch (Exception)
            {

                this.address = "";
            }

            try
            {
                this.sponsor = Settings.Default["sponsor"].ToString();
            }
            catch (Exception)
            {

                this.sponsor = "";
            }
             
            this.telephone = null;
                
            
        }
        #endregion

        #region methods 
        public void save()
        {
            Settings.Default["name"] = this.name;
            Settings.Default["number"]  = this.number;
            Settings.Default["city"]= this.city;
            Settings.Default["state"] = this.state;
            Settings.Default["country"] = this.country;
            Settings.Default["address"] = this.address;
            this.telephone = null;
            Settings.Default["sponsor"] = this.sponsor;
            Settings.Default.Save();
        }
        #endregion

        #region Overwritten methods
        
        
        
        #endregion
    }
}
