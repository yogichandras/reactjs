using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReactjsfirstCrud.Models
{
    public class ActorModel
    {
        
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            [Key, Column(Order = 0)]
            [Required]
            [DisplayName("Id")]
            public int Id { get; set; }

            [Required]
            [MaxLength(50)]
            [DisplayName("Name")]
            public string Name { get; set; }

            [MaxLength(10)]
            [DisplayName("Gender")]
            public string Gender { get; set; }

            [DisplayName("Age")]
            public int? Age { get; set; }

            [MaxLength(255)]
            [DisplayName("Picture")]
            public string Picture { get; set; }
        
    }
}
