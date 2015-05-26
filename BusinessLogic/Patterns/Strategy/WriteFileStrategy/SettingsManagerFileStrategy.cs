using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BusinessLogic
{
    public class SettingsManagerFileStrategy : IManagerFileStrategy
    {
        public ScoutGroup loadFile()
        {
            ScoutGroup S = ScoutGroup.getInstance();
            S.Name = Properties.Settings.Default["name"].ToString();
            try
            {
                S.Number = Convert.ToInt32(Properties.Settings.Default["number"].ToString());
            }
            catch (Exception)
            {
                
            }
            S.City = Properties.Settings.Default["city"].ToString();
            S.State = Properties.Settings.Default["state"].ToString();
            S.Country = Properties.Settings.Default["country"].ToString();      
            S.Address = Properties.Settings.Default["address"].ToString();
            S.Sponsor = Properties.Settings.Default["sponsor"].ToString();      
            return S;
        }

        public void writeFile(ScoutGroup S)
        {
            throw new NotImplementedException();
        }
    }
}
