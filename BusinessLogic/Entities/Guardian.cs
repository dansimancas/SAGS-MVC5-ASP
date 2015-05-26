using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLogic
{
    [Table("Guardians")]
    public class Guardian : IMember
    {
        private INotificationStrategy NotificationStrategy;

        #region Properties

        //TODO: Agregar propiedades inherentes a los guardianes.
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
        public DocumentType Document { get; set; }

        [Required]
        public long Identification { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Telephones { get; set; }

        [Required]
        public string EmailAddresses { get; set; }

      

        #endregion

        #region Methods

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

        //TODO Cambiar document type ID por document type Name
        public override string ToString()
        {
            return "\nGuardian:\nId: " + this.Id +
                "\nName: " + this.Name +
                "\nLast name: " + this.GenderMember +
                "\nAddress: " + this.Address +
                "\nCity: " + this.City +
                "\nTelephones: " + this.Telephones +
                "\nDocument type: " + this.Document +
                "\nIdentification: " + this.Identification;
        }

        #endregion


    }
}
