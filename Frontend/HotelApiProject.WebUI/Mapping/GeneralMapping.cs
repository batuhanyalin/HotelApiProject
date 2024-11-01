using AutoMapper;
using HotelApiProject.WebUI.Dtos.AboutDtos;
using HotelApiProject.WebUI.Dtos.ServiceDtos;
using HotelApiProject.WebUI.Dtos.SocialMediaDtos;
using HotelApiProject.WebUI.Dtos.StaffDtos;
using HotelApiProject.WebUI.Dtos.TestimonialDtos;
using HotelApiProject.EntityLayer.Concrete;
using HotelApiProject.WebUI.Dtos.AppUserDtos;
using HotelApiProject.WebUI.Dtos.SubscribeDtos;
using HotelApiProject.WebUI.Dtos.RoomDtos;
using HotelApiProject.WebUI.Dtos.ContactDtos;

namespace HotelApiProject.WebUI.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<Room,RoomAddDto>().ReverseMap();
            CreateMap<Room,RoomUpdateDto>().ReverseMap();
            CreateMap<Room,RoomListDto>().ReverseMap();

            CreateMap<About, AboutUpdateDto>().ReverseMap();
            CreateMap<About, AboutListDto>().ReverseMap();

            CreateMap<Service, ServiceAddDto>().ReverseMap();
            CreateMap<Service, ServiceListDto>().ReverseMap();
            CreateMap<Service, ServiceUpdateDto>().ReverseMap();

            CreateMap<Staff, StaffAddDto>().ReverseMap();
            CreateMap<Staff, StaffListDto>().ReverseMap();
            CreateMap<Staff, StaffUpdateDto>().ReverseMap();

            CreateMap<Subscribe, SubscribeListDto>().ReverseMap();
            CreateMap<Subscribe, SubscribeUpdateDto>().ReverseMap();

            CreateMap<SocialMedia, SocialMediaAddDto>().ReverseMap();
            CreateMap<SocialMedia, SocialMediaListDto>().ReverseMap();
            CreateMap<SocialMedia, SocialMediaUpdateDto>().ReverseMap();

            CreateMap<Testimonial, TestimonialAddDto>().ReverseMap();
            CreateMap<Testimonial, TestimonialListDto>().ReverseMap();
            CreateMap<Testimonial, TestimonialUpdateDto>().ReverseMap();

            CreateMap<Contact, ContactAddDto>().ReverseMap();
            CreateMap<Contact, ContactListDto>().ReverseMap();


            CreateMap<AppUser, RegisterDto>().ReverseMap();
            CreateMap<AppUser, LoginDto>().ReverseMap();
        }
    }
}
