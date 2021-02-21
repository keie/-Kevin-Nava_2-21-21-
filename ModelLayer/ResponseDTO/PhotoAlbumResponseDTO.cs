using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ModelLayer.ResponseDTO
{
    public class PhotoAlbumResponseDTO
    {
        [Key]
        public int id { get; set; }
        public int idAlbum { get; set; }
        public string Url { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public List<PhotoComments> comments { get; set; }

        public PhotoAlbumResponseDTO Mapper(PhotoAlbumResponseDTO dto, PhotoAlbum obj)
        {
            dto.id = obj.id;
            dto.idAlbum = obj.idAlbum;
            dto.Url = obj.Url;
            dto.name = obj.name;
            dto.description = obj.description;
            return dto;
        }
    }
}