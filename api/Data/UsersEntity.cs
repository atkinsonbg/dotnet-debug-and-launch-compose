using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Data
{

    [Table("users")]
    public class UsersEntity
    {
        [Key]
        [Column("id")]
        public int id { get; set; }

        [Column("fname")]
        public string FirstName { get; set; }

        [Column("lname")]
        public string LastName { get; set; }
    }
}