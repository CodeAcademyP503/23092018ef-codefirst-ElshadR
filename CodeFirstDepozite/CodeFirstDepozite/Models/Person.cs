using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDepozite.Models
{
    [Table(name:"People", Schema ="depozite")]
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required(AllowEmptyStrings =false,ErrorMessage ="Name is required")]
        [StringLength(maximumLength:90,MinimumLength =3)]
        public string Name { get; set; }

        [Required(AllowEmptyStrings =false,ErrorMessage ="Name is required")]
        [StringLength(maximumLength:90,MinimumLength =4)]
        public string Surname { get; set; }


        [Required(AllowEmptyStrings =false,ErrorMessage ="Name is required")]
        [MaxLength(150)]
        public string PasportNumber { get; set; }

        public ICollection<Credit> Credits { get; set; }
        public Person()
        {
            Credits = new HashSet<Credit>();
        }
    }
}
