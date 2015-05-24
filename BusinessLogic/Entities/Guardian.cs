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
        #region Atributes

        private int id;
        private static int val = 0;

        #endregion

        #region Properties

        //TODO: Agregar propiedades inherentes a los guardianes.
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
        public long Identification { get; set; }

        [Required]
        public List<long> Telephones { get; set; }

        [Required]
        public List<string> EmailAddresses { get; set; }

        [Required]
        public DocumentType Document { get; set; }

        #endregion

        #region Constructors

        public Guardian()
        {
            this.Id = ++val;
            this.Name = "Daniela";
            this.Lastname = "Simancas Mateus";
            this.Gender = "Femenine";
            this.Address = "Torices";
            this.City = "Cartagena";
            this.Telephones = new List<long>();
            this.EmailAddresses = new List<string>();
            this.Document = DocumentType.Cedula;
            this.Identification = 1050692143;
        }

        public Guardian(string name, string lastname, string gender, string address, string city, List<long> tel, List<string> em, DocumentType doc, long ident)
        {
            this.Id = ++val;
            this.Name = name;
            this.Lastname = lastname;
            this.Gender = gender;
            this.Address = address;
            this.City = city;
            this.Telephones = (tel != null) ? tel : new List<long>();
            this.EmailAddresses = (em != null) ? em : new List<string>();
            this.Document = doc;
            this.Identification = ident;
        }

        #endregion

        #region Methods

        public void addTelephone(long t)
        {
            Telephones.Add(t);
        }

        public void addEmailAddress(string e)
        {
            EmailAddresses.Add(e);
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

        public void Update(Activity activity, string message)
        {
            Console.WriteLine("\nGUARDIANS/" + activity.Name + " notification: " + message + ".");
            string body = "The activity named \"" + activity.Name + "\" has a new notification for you: " + message;
            SendEmail send = new SendEmail(this.EmailAddresses, "Activity: " + activity.Name + " Notification", body);
        }

        #endregion

        #region Overridden methods

        //TODO Cambiar document type ID por document type Name
        public override string ToString()
        {
            return "\nGuardian:\nId: " + this.Id +
                "\nName: " + this.Name +
                "\nLast name: " + this.Gender +
                "\nAddress: " + this.Address +
                "\nCity: " + this.City +
                "\nTelephones: " + printTelephones(Telephones) +
                "\nDocument type: " + this.Document +
                "\nIdentification: " + this.Identification;
        }

        #endregion
    }
}
