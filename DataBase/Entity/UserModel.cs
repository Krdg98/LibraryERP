using System.ComponentModel.DataAnnotations;

namespace LibraryERP.DataBase.Entity
{
	public class UserModel
	{
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
