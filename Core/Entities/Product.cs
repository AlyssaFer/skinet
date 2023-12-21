using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    //each property represents attributes in database table called product
    public class Product
    {
       public int Id { get; set; } 
       public string Name { get; set; }

    }
}