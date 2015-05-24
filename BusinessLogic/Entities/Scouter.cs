using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Scouter : IMember

    {
        #region Atributes

        private int id;
        private string name;
        private string lastname;
        private string gender;
        private string address;
        private string city;
        private List<long> telephones;
        private List<string> emailAddresses;
        private int documentTypeID;
        private long identification;        
        private List<string> guardiansId;
        private MedicalHistory medicalHistory;
        private static int val = 0;
        //Education and work experience
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
        public MedicalHistory MedicalHistoryId
        {
            get { return medicalHistory; }
        }
        public List<long> Telephones
        {
            get { return telephones; }
            set { telephones = value; }
        }
        public List<string> EmailAddresses
        {
            get { return emailAddresses; }
            set { emailAddresses = value; }
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
        public virtual Education ScouterEducation
        {
            get { return scouterEducation; }
            set { scouterEducation = value; }
        }
        public virtual string WorkExperience
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
            this.telephones = new List<long>();
            this.emailAddresses = new List<string>();
            this.documentTypeID = 1;
            this.identification = 1234;
            this.guardiansId = new List<string>();
            this.scouterEducation = new Education();
            this.medicalHistory = new MedicalHistory(this.id);
            this.workExperience = "Programmer";
        }

        //Constructor with all atributes
        public Scouter(string name, string lastname, string gender, string address, string city, List<long> tel, List<string> em, int doc, long id, List<string> guard, MedicalHistory med, Education education, string exp)
        {
            this.id = ++val;
            this.name = name;
            this.lastname = lastname;
            this.gender = gender;
            this.address = address;
            this.city = city;
            this.telephones = tel;
            this.emailAddresses = (em != null) ? em : new List<string>();
            this.documentTypeID = doc;
            this.identification = id;
            this.guardiansId = guard;
            this.medicalHistory = (med.MemberId == this.id) ? med : new MedicalHistory(this.id);
            this.scouterEducation = education;
            this.workExperience = exp;
        }

        //Constructor without MedicalHistory, in case you dont know your scouter id in the moment of instantiating
        public Scouter(string name, string lastname, string gender, string address, string city, List<long> tel, List<string> em, int doc, long id, List<string> guard, Education education, string exp)
        {
            this.id = ++val;
            this.name = name;
            this.lastname = lastname;
            this.gender = gender;
            this.address = address;
            this.city = city;
            this.telephones = tel;
            this.emailAddresses = (em != null) ? em : new List<string>();
            this.documentTypeID = doc;
            this.identification = id;
            this.guardiansId = guard;
            this.medicalHistory = new MedicalHistory(this.id);
            this.scouterEducation = education;
            this.workExperience = exp;
        }

        //Constructor without elaborated or composed atributes
        public Scouter(string name, string lastname, string gender, string address, string city, int doc)
        {
            this.id = ++val;
            this.name = name;
            this.lastname = lastname;
            this.gender = gender;
            this.address = address;
            this.city = city;
            this.telephones = new List<long>();
            this.emailAddresses = new List<string>();
            this.documentTypeID = doc;
            this.guardiansId = new List<string>();
            this.medicalHistory = new MedicalHistory();
            this.scouterEducation = new Education();
        }

        #endregion

        #region Methods
        
        public virtual void addGuardian(string guardianId)
        {
            if (guardiansId != null)
            {
                this.guardiansId.Add(guardianId);
            }
            else
            {
                this.guardiansId = new List<string>();
                this.guardiansId.Add(guardianId);
            }
            
        }

        public virtual void setEducation(string level, string type, string obtainedTitle, string institution, int year, string city)
        {
            Education temp = new Education(level, type, obtainedTitle, institution, year, city);
        }

        public virtual void addWorkExperience(string ex)
        {
            this.workExperience = (this.workExperience == "") ? ex : ". " + ex;
        }

        public virtual void addTelephone(long t)
        {
            if (telephones != null)
            {
                telephones.Add(t);
            }
            else
            {
                telephones = new List<long>();
                telephones.Add(t);
            }
            
        }

        public void addEmailAddress(string e)
        {
            if (emailAddresses != null)
            {
                emailAddresses.Add(e);
            }
            else
            {
                emailAddresses = new List<string>();
                emailAddresses.Add(e);
            }
        }

        protected string printTelephones(List<long> tels)
        {
            if (tels != null && tels.Count > 0)
            {
                string value = "";
                foreach (long o in tels)
                {
                    value += o + ", ";
                }
                return value.Substring(0, value.Length - 2);
            }
            else return "There are no telephone numbers asigned yet.";
        }

        protected string printStringList(List<string> mylist)
        {
            if (mylist != null && mylist.Count > 0)
            {
                string value = "";
                foreach (string s in mylist)
                {
                    value += s + ", ";
                }
                return value.Substring(0, value.Length - 2);
            }
            else return "There are no elements asigned yet.";
        }

        public void Update(Activity activity, string message)
        {
            Console.WriteLine("\nSCOUTERS/" + activity.Name + " notification: " + message + ".");
            string body = "The activity named \"" + activity.Name + "\" has a new notification for you: " + message;
            SendEmail send = new SendEmail(this.emailAddresses, "Activity: " + activity.Name + " Notification", body);
        }

        #endregion

        #region Overridden methods

        public override string ToString()
        {
            return "\nScouter:\nId: " + this.id +
                "\nName: " + this.name +
                "\nLast name: " + this.gender +
                "\nAddress: " + this.address +
                "\nCity: " + this.city +
                "\nTelephones: " + printTelephones(telephones) +
                "\nDocument type: " + this.documentTypeID +
                "\nIdentification: " + this.identification +
                "\nGuardians : " + printStringList(guardiansId) +
                "\nMedical History ID: " + this.medicalHistory.Id;
        }

        #endregion

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
    }
}
