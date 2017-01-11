using System;
using System.ComponentModel.DataAnnotations;

namespace Channel6.Model
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [StringLength(64)]
        public string Name { get; set; }

        [StringLength(2)]
        public string Country { get; set; }

        public UserStatus Status { get; set; }
        public DateTime RegisterDateTime { get; set; }
        public DateTime LastLogin { get; set; }

    }

    public enum UserStatus
    {
        Registered = 1,
        Activated = 2,
        Deactivated = 9
    }
}