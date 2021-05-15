using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class Customer:IEntity
    {
        [Key]
        public int UserId { get; set; }
        public string CompanyName { get; set; }

        public virtual User user { get; set; }
        public virtual ICollection<Rental> Rentals { get; set; }
    }
}
