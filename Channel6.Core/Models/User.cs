using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Channel6.Core.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string Name { get; set; }

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