using System;

namespace CarNotes.Models
{
    public partial class Comments
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }
        public int NoteId { get; set; }

        public virtual Notes Note { get; set; }
    }
}
