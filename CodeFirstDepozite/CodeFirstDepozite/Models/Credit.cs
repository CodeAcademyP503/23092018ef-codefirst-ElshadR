using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDepozite.Models
{
    [Table(name:"Credits" , Schema ="depozite")]
    public class Credit
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]

        public decimal Amount { get; set; }

        [Required]
        public DateTime OpenDatetime { get; set; }


        public DateTime? CloseDatetime { get; set; }

        public Person Person { get; set; }
        public int Person_Id { get; set; }

    }
}
