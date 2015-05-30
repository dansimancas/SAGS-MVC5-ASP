using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BusinessLogic
{
    public class SettingsFileManagerStrategy : IFileManagerStrategy
    {
        public ScoutGroup loadFile()
        {
            ScoutGroup S = ScoutGroup.getInstance();
            S.Name = Properties.Settings.Default["name"].ToString();
            S.Number = Properties.Settings.Default.number;
            S.City = Properties.Settings.Default.city;
            S.State = Properties.Settings.Default.state;
            S.Country = Properties.Settings.Default.country;
            S.Address = Properties.Settings.Default.address;
            S.Sponsor = Properties.Settings.Default.sponsor;
            return S;
        }

        public void writeFile(ScoutGroup S)
        {
            Properties.Settings.Default.name = S.Name;
            Properties.Settings.Default.number = S.Number;
            Properties.Settings.Default.city = S.City;
            Properties.Settings.Default.state = S.State;
            Properties.Settings.Default.country = S.Country;
            Properties.Settings.Default.address = S.Address;
            Properties.Settings.Default.sponsor = S.Sponsor;
            try
            {
                Properties.Settings.Default.Save();
            }
            catch (Exception)
            {
            }
            
        }
    }
}
