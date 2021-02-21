using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ModelLayer.ResponseDTO
{
    public class AlbumResponseDTO
    {
        
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public List<PhotoAlbumResponseDTO> photos { get; set; }

        public AlbumResponseDTO Mapper(AlbumResponseDTO dto, Album obj)
        {
            dto.id = obj.id;
            dto.name = obj.name;

            return dto;
        }
    }
}