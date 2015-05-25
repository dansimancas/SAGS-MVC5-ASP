using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLogic
{
    public class User
    {
        #region Properties

        [Key]
        public int Id { get; set; }

        [Required]
        public UserRole Role { get; set; }

        [Required]
        public int MemberId { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { set; get; }

        #endregion

        #region Methods

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
