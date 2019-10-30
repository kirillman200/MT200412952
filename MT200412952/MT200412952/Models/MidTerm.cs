using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MT200412952.Models
{
    public class MidTerm
    {
        public virtual int Id { get; set; }
        [Required]
        public virtual String Message { get; set; }
        [Required]
        public virtual String Name { get; set; }

        
       
       
        public virtual DateTime Date { get; set; }
    }
}
