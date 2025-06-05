using System;

namespace SpecialTopic.UsedBooks.Backend.Entities
{
    public class BookImageEntity
    {
        public int BookID { get; set; }
        public string ImagePath { get; set; }
        public int ImageIndex { get; set; }
        public DateTime UploadedAt { get; set; }
    }
}