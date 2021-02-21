using System;
using System.ComponentModel.DataAnnotations;

namespace ModelLayer
{
    public class PhotoComments
    {
       [Key]
        public int id { get; set; }
        public int idPhotoAlbum { get; set; }
        public DateTime datePublish { get; set; }
        public string content { get; set; }
        
        
    }
}