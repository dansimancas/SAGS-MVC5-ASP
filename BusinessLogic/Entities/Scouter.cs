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
        private INotificationStrategy NotificationStrategy;

        #region Properties

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Lastname { get; set; }

        [Required]
        public Gender GenderMember { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Telephones { get; set; }

        [Required]
        public string EmailAddresses { get; set; }

        [Required]
        public DocumentType Document { get; set; }

        [Required]
        public long Identification { get; set; }

        [NotMapped]
        public List<string> GuardiansId { get; set; }

        [NotMapped]
        public MedicalHistory ScouterMedicalHistory { get; set; }

        [NotMapped]
        public EducationHistory ScouterEducation { get; set; }

        [Required]
        [StringLength(200)]
        public string WorkExperience { get; set; }

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
            string title = "Activity: " + activity.Name + " Notification";
            NotificationStrategy.sendNotification(this, title, body);
        }

        public long Key()
        {
            return this.Identification;
        }

        public void setStrategy(INotificationStrategy strategy)
        {
            NotificationStrategy = strategy;
        }

        #endregion

        #region Overridden methods

        public override string ToString()
        {
            return "\nScouter:\nId: " + this.Id +
                "\nName: " + this.Name +
                "\nLast name: " + this.GenderMember +
                "\nAddress: " + this.Address +
                "\nCity: " + this.City +
                "\nTelephones: " + this.Telephones +
                "\nDocument type: " + this.Document +
                "\nIdentification: " + this.Identification +
                "\nGuardians : " + printStringList(GuardiansId) +
                "\nMedical History ID: " + this.ScouterMedicalHistory.Id;
        }

        #endregion
        
    }
}