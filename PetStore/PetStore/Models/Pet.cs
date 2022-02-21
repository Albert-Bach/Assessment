using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Models
{
    internal class Pet
    {

       public long Id { get; set; }
       public Category Category { get; set; }

       public string Name { get; set; }

       public string[] PhotoUrls { get; set; }

       public PetStatus Status { get; set; }

      public Tag[] Tags { get; set; }
    }

    
}
