using System.ComponentModel.DataAnnotations;

namespace ModelLayer
{
    public class PhotoAlbum
    {
        [Key]
        public int id { get; set; }
        public int idAlbum { get; set; }
        public string Url { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }
}