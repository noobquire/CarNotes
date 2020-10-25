using System;
using System.Collections.Generic;

namespace CarNotes.Models
{
    public partial class Cars
    {
        public Cars()
        {
            Notes = new HashSet<Notes>();
        }

        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Color { get; set; }
        public string Engine { get; set; }
        public int Volume { get; set; }
        public string BodyType { get; set; }
        public DateTime Created { get; set; }

        public virtual ICollection<Notes> Notes { get; set; }
    }
}
