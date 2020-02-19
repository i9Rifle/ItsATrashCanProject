using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThisProjectIsATrashCan.Models
{
    public class Pickup
    {
        [Key]
        public int PickupId { get; set; }
        public DateTime ScheduledPickup { get; set; }

        public bool PickupCompleted { get; set; }

        public string PickUpDay { get; set; }

        public DateTime OneTimePickup { get; set; }
    }
}
