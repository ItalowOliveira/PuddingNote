using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Models
{
    internal class Notes
    {

        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Notes(string id, string name, String description){


            Id = id;
            Name = name;
            Description = description;

         }

    }

}
