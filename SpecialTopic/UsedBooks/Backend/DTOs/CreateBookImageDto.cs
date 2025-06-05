using System.Drawing;

namespace SpecialTopic.UsedBooks.Backend.DTOs
{
    public class CreateBookImageDto
    {
        public Image BookImage { get; set; }
        public string Ext { get; set; }
        public int ImageIndex { get; set; }
    }

}
