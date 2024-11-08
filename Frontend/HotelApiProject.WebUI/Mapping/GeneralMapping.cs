﻿using AutoMapper;
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
using HotelApiProject.WebUI.Dtos.ReservationDtos;
using HotelApiProject.WebUI.Dtos.GuestDtos;
using HotelApiProject.WebUI.Dtos.MessageCategoryDtos;
using HotelApiProject.WebUI.Dtos.WorkLocationDtos;

namespace HotelApiProject.WebUI.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {

            CreateMap<WorkLocation, WorkLocationListDto>().ReverseMap();
            CreateMap<WorkLocation, WorkLocationAddDto>().ReverseMap();
            CreateMap<WorkLocation, WorkLocationUpdateDto>().ReverseMap();

            CreateMap<AppUser, UserListDto>().ReverseMap();
            CreateMap<AppUser, UserAddDto>().ReverseMap();
            CreateMap<AppUser, UserUpdateDto>().ReverseMap();

            CreateMap<MessageCategory, MessageCategoryListDto>().ReverseMap();
            CreateMap<MessageCategory, MessageCategoryUpdateDto>().ReverseMap();
            CreateMap<MessageCategory, MessageCategoryAddDto>().ReverseMap();

            CreateMap<Room, RoomListDto>().ReverseMap();
            CreateMap<Room, RoomAddDto>().ReverseMap();
            CreateMap<Room, RoomUpdateDto>().ReverseMap();

            CreateMap<Guest, GuestUpdateDto>().ReverseMap();
            CreateMap<Guest, GuestListDto>().ReverseMap();
            CreateMap<Guest, GuestAddDto>().ReverseMap();


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

            CreateMap<Reservation, ReservationAddDto>().ReverseMap();
            CreateMap<Reservation, ReservationListDto>().ReverseMap();
            CreateMap<Reservation, ReservationUpdateDto>().ReverseMap();
        }
    }
}
