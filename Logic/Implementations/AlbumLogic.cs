using System;
using System.Collections.Generic;
using System.Drawing;
using Logic.Interfaces;
using ModelLayer;
using ModelLayer.ResponseDTO;
using UnitOfWorkLayer;

namespace Logic.Implementations
{
    public class AlbumLogic:IAlbumLogic
    {
        private IUnitOfWork _unitOfWork;

        public AlbumLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<AlbumResponseDTO> GetList()
        {
            try
            {
                var albums = _unitOfWork.IAlbum.GetList();
                var photos = _unitOfWork.IPhotoAlbum.GetList();
                var comments = _unitOfWork.IPhotoComments.GetList();
                List<AlbumResponseDTO> listDTO = new List<AlbumResponseDTO>();
                foreach (var recAlbum in albums)
                {
                    AlbumResponseDTO dto = new AlbumResponseDTO();
                    List<PhotoAlbumResponseDTO> photosDTO = new List<PhotoAlbumResponseDTO>();
                    foreach (var recPhoto in photos)
                    {
                        PhotoAlbumResponseDTO photoAlbumDTO = new PhotoAlbumResponseDTO();
                        if (recAlbum.id == recPhoto.idAlbum)
                        {
                            List<PhotoComments> commentsList = new List<PhotoComments>();
                            dto.Mapper(dto, recAlbum);
                            photoAlbumDTO.Mapper(photoAlbumDTO, recPhoto);
                            foreach (var recComment in comments)
                            {
                                if (recComment.idPhotoAlbum == recPhoto.id)
                                {
                                    commentsList.Add(recComment);
                                }
                            }
                            if (commentsList.Count > 0)
                            {
                                photoAlbumDTO.comments = commentsList;
                            }
                            photosDTO.Add(photoAlbumDTO);
                        }
                        if (photosDTO.Count > 0)
                        {
                            dto.photos = photosDTO;
                        }
                    }
                    listDTO.Add(dto);
                }
                return (listDTO);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}