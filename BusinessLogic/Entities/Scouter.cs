using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLogic
{
    [Table("Scouters")]
    public class Scouter : IMember

    {
        #region Atributes

        private int id;
        private static int val = 0;

        #endregion

        #region Properties

        [Key]
        public int Id
        {
            get { return id; }
            set { id = ++val; }
        }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Lastname { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public List<string> GuardiansId { get; set; }

        [Required]
        public MedicalHistory ScouterMedicalHistory { get; set; }

        [Required]
        public List<long> Telephones { get; set; }

        [Required]
        public List<string> EmailAddresses { get; set; }

        [Required]
        public long Identification { get; set; }

        [Required]
        public DocumentType Document { get; set; }

        [Required]
        public virtual EducationHistory ScouterEducation { get; set; }

        [Required]
        [StringLength(200)]
        public virtual string WorkExperience { get; set; }

        #endregion

        #region Constructors

        public Scouter() 
        {
            this.Id = ++val;
            this.Name = "Ángel";
            this.Lastname = "Jiménez";
            this.Gender = "Male";
            this.Address = "Ternera";
            this.City = "Cartagena";
            this.Telephones = new List<long>();
            this.EmailAddresses = new List<string>();
            this.Document = DocumentType.Cedula;
            this.Identification = 1234;
            this.GuardiansId = new List<string>();
            this.ScouterEducation = new EducationHistory();
            this.ScouterMedicalHistory = new MedicalHistory(this.Id);
            this.WorkExperience = "Programmer";
        }

        //Constructor with all atributes
        public Scouter(string name, string lastname, string gender, string address, string city, List<long> tel, List<string> em, DocumentType doc, long id, List<string> guard, MedicalHistory med, EducationHistory education, string exp)
        {
            this.Id = ++val;
            this.Name = name;
            this.Lastname = lastname;
            this.Gender = gender;
            this.Address = address;
            this.City = city;
            this.Telephones = tel;
            this.EmailAddresses = (em != null) ? em : new List<string>();
            this.Document = doc;
            this.Identification = id;
            this.GuardiansId = guard;
            this.ScouterMedicalHistory = (med.MemberId == this.Id) ? med : new MedicalHistory(this.Id);
            this.ScouterEducation = education;
            this.WorkExperience = exp;
        }

        //Constructor without MedicalHistory, in case you dont know your scouter id in the moment of instantiating
        public Scouter(string name, string lastname, string gender, string address, string city, List<long> tel, List<string> em, DocumentType doc, long id, List<string> guard, EducationHistory education, string exp)
        {
            this.Id = ++val;
            this.Name = name;
            this.Lastname = lastname;
            this.Gender = gender;
            this.Address = address;
            this.City = city;
            this.Telephones = tel;
            this.EmailAddresses = (em != null) ? em : new List<string>();
            this.Document = doc;
            this.Identification = id;
            this.GuardiansId = guard;
            this.ScouterMedicalHistory = new MedicalHistory(this.Id);
            this.ScouterEducation = education;
            this.WorkExperience = exp;
        }

        #endregion

        #region Methods
        
        public virtual void addGuardian(string guardianId)
        {
            if (GuardiansId != null)
            {
                this.GuardiansId.Add(guardianId);
            }
            else
            {
                this.GuardiansId = new List<string>();
                this.GuardiansId.Add(guardianId);
            }
            
        }

        public virtual void setEducation(string level, string type, string obtainedTitle, string institution, int year, string city)
        {
            EducationHistory temp = new EducationHistory(level, type, obtainedTitle, institution, year, city);
        }

        public virtual void addWorkExperience(string ex)
        {
            this.WorkExperience = (this.WorkExperience == "") ? ex : ". " + ex;
        }

        public virtual void addTelephone(long t)
        {
            if (Telephones != null)
            {
                Telephones.Add(t);
            }
            else
            {
                Telephones = new List<long>();
                Telephones.Add(t);
            }
            
        }

        public void addEmailAddress(string e)
        {
            if (EmailAddresses != null)
            {
                EmailAddresses.Add(e);
            }
            else
            {
                EmailAddresses = new List<string>();
                EmailAddresses.Add(e);
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
            SendEmail send = new SendEmail(this.EmailAddresses, "Activity: " + activity.Name + " Notification", body);
        }

        #endregion

        #region Overridden methods

        public override string ToString()
        {
            return "\nScouter:\nId: " + this.Id +
                "\nName: " + this.Name +
                "\nLast name: " + this.Gender +
                "\nAddress: " + this.Address +
                "\nCity: " + this.City +
                "\nTelephones: " + printTelephones(Telephones) +
                "\nDocument type: " + this.Document +
                "\nIdentification: " + this.Identification +
                "\nGuardians : " + printStringList(GuardiansId) +
                "\nMedical History ID: " + this.ScouterMedicalHistory.Id;
        }

        #endregion

    }
}
