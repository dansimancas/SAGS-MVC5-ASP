using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public struct EducationHistory
    {
        string level; //highschool, undergraduate, graduate
            string type; // classic, comercial, technical, technologic, professional, specialization, master, doctorate
            string obtainedTitle;
            string institution;
            int year;
            string city;

            public EducationHistory(string level, string type, string obtainedTitle, string institution, int year, string city)
            {
                this.level = level;
                this.type = type;
                this.obtainedTitle = obtainedTitle;
                this.institution = institution;
                this.year = year;
                this.city = city;
            }
    }
}
