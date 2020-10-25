using System;
using System.Collections.Generic;

namespace CarNotes.Models
{
    public partial class Notes
    {
        public Notes()
        {
            Comments = new HashSet<Comments>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int CarId { get; set; }

        public virtual Cars Car { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
    }
}
