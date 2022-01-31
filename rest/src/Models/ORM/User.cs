using System.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace rest.src.Models.ORM
{
    public class User : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        [Required(ErrorMessage = "This field is required...")]
        [DisplayName("name")]
        public string name { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        [Required(ErrorMessage = "This field is required...")]
        [DisplayName("username")]
        public string username { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        [Required(ErrorMessage = "This field is required...")]
        [DisplayName("email")]
        public string email { get; set; }
        public string phone { get; set; }
        public string website { get; set; }
        public Company company { get; set; }
        public Address address { get; set; }
    }
}