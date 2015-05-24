using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLogic
{
    public class Teen : IMember
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
        public List<long> Telephones { get; set; }

        [Required]
        public List<string> EmailAddresses { get; set; }

        [Required]
        public DocumentType Document { get; set; }

        [Required]
        public long Identification { get; set; }

        [Required]
        public List<string> GuardiansId { get; set; }

        [Required]
        public MedicalHistory TeenMedicalHistory { get; set; }

        #endregion

        #region Constructors

        public Teen()
        {
            this.Id = ++val;
            this.Name = "Laura Cristina";
            this.Lastname = "Schiatti Sisó";
            this.Gender = "Female";
            this.Address = "Manga";
            this.City = "Cartagena";
            this.Telephones = new List<long>();
            this.EmailAddresses = new List<string>();
            this.Document = DocumentType.Cedula;
            this.Identification = 1050962143;
            this.TeenMedicalHistory = new MedicalHistory(this.Id);
        }

        public Teen(string name, string lastname, string gender, string address, string city, List<long> tels, List<string> em, DocumentType doc, long id, List<string> guardians, MedicalHistory med)
        {
            this.Id = ++val;
            this.Name = name;
            this.Lastname = lastname;
            this.Gender = gender;
            this.Address = address;
            this.City = city;
            this.Telephones = tels;
            this.EmailAddresses = (em != null) ? em : new List<string>();
            this.Document = doc;
            this.Identification = id;
            this.GuardiansId = guardians;
            //Ensuring that the medical history is his/her own.
            this.TeenMedicalHistory = (med.MemberId == this.Id) ? med : new MedicalHistory(this.Id);
        }

        //Constructor without MedicalHistory, in case you dont know your scouter id in the moment of instantiating
        public Teen(string name, string lastname, string gender, string address, string city, List<long> tels, List<string> em, DocumentType doc, long id, List<string> guardians)
        {
            this.Id = ++val;
            this.Name = name;
            this.Lastname = lastname;
            this.Gender = gender;
            this.Address = address;
            this.City = city;
            this.Telephones = tels;
            this.EmailAddresses = (em != null) ? em : new List<string>();
            this.Document = doc;
            this.Identification = id;
            this.GuardiansId = guardians;
            //Ensuring that the medical history is his/her own.
            this.TeenMedicalHistory = new MedicalHistory(this.Id);
        }

        #endregion

        #region Methods

        public void addTelephone(long t)
        {
            Telephones.Add(t);
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
            Console.WriteLine("\nTEENS/" + activity.Name + " notification: " + message + ".");
            string body = "The activity named \"" + activity.Name + "\" has a new notification for you: " + message;
            SendEmail send = new SendEmail(this.EmailAddresses, "Activity: " + activity.Name + " Notification", body);
        }
        
        #endregion

        #region Overridden methods

        public override string ToString()
        {
            return "\nTeen:\nId: " + this.Id +
                "\nName: " + this.Name +
                "\nLast name: " + this.Gender +
                "\nAddress: " + this.Address +
                "\nCity: " + this.City +
                "\nTelephones: " + printTelephones(Telephones) +
                "\nDocument type: " + this.Document +
                "\nIdentification: " + this.Identification +
                "\nGuardians : " + printStringList(GuardiansId) +
                "\nMedical History ID: " + this.TeenMedicalHistory.Id;
        }

        #endregion
    }
}
