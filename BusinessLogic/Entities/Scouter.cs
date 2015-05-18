using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Scouter : InterfaceMember

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
        private int medicalHistoryId;
        private static int val = 0;

        //Education and work experience

        public struct Education
        {
            string level; //highschool, undergraduate, graduate
            string type; // classic, comercial, technical, technologic, professional, specialization, master, doctorate
            string obtainedTitle;
            string institution;
            int year;
            string city;

            public Education(string l, string t, string o, string i, int y, string c)
            {
                level = l;
                type = t;
                obtainedTitle = o;
                institution = i;
                year = y;
                city = c;
            }
        }

        private Education scouterEducation;
        private string workExperience;

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
        public List<string> GuardiansId
        {
            get { return guardiansId; }
            set { guardiansId = value; }
        }
        public int MedicalHistoryId
        {
            get { return medicalHistoryId; }
            set { medicalHistoryId = value; }
        }
        public List<long> Telephones
        {
            get { return telephones; }
            set { telephones = value; }
        }
        public long Identification
        {
            get { return identification; }
            set { identification = value; }
        }
        public int DocumentTypeID
        {
            get { return documentTypeID; }
            set { documentTypeID = value; }
        }
        public Education ScouterEducation
        {
            get { return scouterEducation; }
            set { scouterEducation = value; }
        }
        public string WorkExperience
        {
            get { return workExperience; }
            set { workExperience = value; }
        }

        #endregion

        #region Constructors

        public Scouter() 
        {
            this.id = ++val;
            this.name = "Ángel";
            this.lastname = "Jiménez";
            this.gender = "Male";
            this.address = "Ternera";
            this.city = "Cartagena";
            this.telephones = null;
            this.identification = 1234;
            this.documentTypeID = 1;
            this.scouterEducation = new Education();
            this.workExperience = "Programmer";
        }

        //Constructor with all atributes
        public Scouter(string name, string lastname, string gender, string address, string city, List<long> tel, int doc, List<string> guard, int med, Education education, string exp)
        {
            this.id = ++val;
            this.name = name;
            this.lastname = lastname;
            this.gender = gender;
            this.address = address;
            this.city = city;
            this.telephones = tel;
            this.documentTypeID = doc;
            this.guardiansId = guard;
            this.medicalHistoryId = med;
            this.scouterEducation = education;
            this.workExperience = exp;
        }

        //Constructor without elaborated or composed atributes
        public Scouter(string name, string lastname, string gender, string address, string city, List<long> tel, int doc, int med)
        {
            this.id = ++val;
            this.name = name;
            this.lastname = lastname;
            this.gender = gender;
            this.address = address;
            this.city = city;
            this.telephones = tel;
            this.documentTypeID = doc;
            this.guardiansId = new List<string>();
            this.medicalHistoryId = med;
            this.scouterEducation = new Education();
        }

        #endregion

        #region Methods
        
        public void addGuardian(string guardianId)
        {
            this.guardiansId.Add(guardianId);
        }

        public void setEducation(string level, string type, string obtainedTitle, string institution, int year, string city)
        {
            Education temp = new Education(level, type, obtainedTitle, institution, year, city);
        }

        public void addWorkExperience(string ex)
        {
            WorkExperience += ex;
        }

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
