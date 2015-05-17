using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class User
    {
        #region Atributes

        private int id;
        private string role;
        private int memberId;
        private string email;
        private string password;

        #endregion

        #region Properties

        public int Id { get; set; }
        public string Role { get; set; }
        public int MemberId { get; set; }
        public string Email { get; set; }
        public string Password { set; get; }

        #endregion

        #region Constructors

        public User(int id, string role, int memberid, string email, string password)
        {
            this.id = id;
            this.role = role;
            this.memberId = memberid;
            this.email = email;
            this.password = password;
        }

        #endregion

        #region Overwritten constructors

        public override bool Equals(object obj)
        {
            User u = (User) obj;
            return (this.id == u.Id) && (this.role == u.Role) && (this.memberId == u.MemberId) && (this.email == u.Email); 
        }

        public override string ToString()
        {
            return "\nUser:\nId: " + this.id +
                "\nRole: " + this.role +
                "\nInterfaceMember Id: " + this.memberId +
                "\nEmail: " + this.email;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion
    }
}
