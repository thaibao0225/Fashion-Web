using System.ComponentModel;

namespace Fashion_Model.Models
{
    public class UsersModel
    {
        [DisplayName("Id")]
        public string user_Id { get; set; }

        [DisplayName("First Name")]
        public string user_FirstName { get; set; }

        [DisplayName("Last Name")]
        public string user_LastName { get; set; }

        [DisplayName("User Name")]
        public string user_UserName { get; set; }

        [DisplayName("Email")]
        public string user_Email { get; set; }

        [DisplayName("Delete")]
        public Boolean is_Delete { get; set; }

        [DisplayName("Role Name")]
        public string user_RoleName { get; set; }

    }
}
