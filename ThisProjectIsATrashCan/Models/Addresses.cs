using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ThisProjectIsATrashCan.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

    }
}
