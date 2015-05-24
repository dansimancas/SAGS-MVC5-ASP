using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLogic
{
    public class User : IObserver
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
        public UserRole Role { get; set; }

        [Required]
        public int MemberId { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { set; get; }

        #endregion

        #region Constructors

        public User()
        {
            this.Id = ++val;
            this.Role = UserRole.Standard;
            this.MemberId = 1234;
            this.Email = "lauri_cdd@hotmail.com";
            this.Password = "1234qwer";
        }

        public User(UserRole role, int memberid, string email, string password)
        {
            this.Id = ++val;
            this.Role = role;
            this.MemberId = memberid;
            this.Email = email;
            this.Password = password;
        }

        #endregion

        #region Methods

        public void Update(Activity activity, string message)
        {
            Console.WriteLine("\nUSERS/" + activity.Name + " notification: " + message + ".");
            string body = "The activity named \"" + activity.Name + "\" has a new notification for you: " + message;
            SendEmail send = new SendEmail(this.Email, "Activity: " + activity.Name + " Notification", body);
        }

        #endregion

        #region Overridden methods

        public override bool Equals(object obj)
        {
            User u = (User) obj;
            return (this.Id == u.Id) && (this.Role == u.Role) && (this.MemberId == u.MemberId) && (this.Email == u.Email); 
        }

        public override string ToString()
        {
            return "\nUser:\nId: " + this.Id +
                "\nRole: " + this.Role +
                "\nIMember Id: " + this.MemberId +
                "\nEmail: " + this.Email;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion
    }
}
