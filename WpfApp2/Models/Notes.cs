using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Models
{
    public class Notes
    {
        private static int proximoId = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public static int GlobalNoteId;

        public Notes(string name, String description) {

            Id = proximoId++;
            Name = name;
            Description = description;

        }

    }

}
