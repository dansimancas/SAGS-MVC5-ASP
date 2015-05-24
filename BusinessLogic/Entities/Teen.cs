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

        #endregion

        #region Properties

        [Key]
        public int Id
        {
            get { return id; }
            set { id = value; }
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

        [NotMapped]
        public virtual List<long> Telephones { get; set; }

        [NotMapped]
        public virtual List<string> EmailAddresses { get; set; }

        [Required]
        public DocumentType Document { get; set; }

        [Required]
        public long Identification { get; set; }

        [NotMapped]
        public virtual List<string> GuardiansId { get; set; }

        [NotMapped]
        public MedicalHistory TeenMedicalHistory { get; set; }

        #endregion

        #region Constructors


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
