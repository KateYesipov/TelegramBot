﻿using AutoMapper;
using TelegramChatBlazor.DAL.Entities;

namespace TelegramChatBlazor.DAL.MappingProfile
{
    public class DataAccessMapingProfile : Profile
    {
        public DataAccessMapingProfile()
        {
            CreateMap<Message, Domain.Models.Messages.Message>().ReverseMap();
            CreateMap<Attachment, Domain.Models.Messages.Attachment>().ReverseMap();
            CreateMap<Chat, Domain.Models.Chats.Chat>().ReverseMap();
            CreateMap<Bot, Domain.Models.Bot>().ReverseMap();
            CreateMap<Color, Domain.Models.Color>().ReverseMap();
            CreateMap<Manager, Domain.Models.Managers.Manager>().ReverseMap();
            CreateMap<Answer, Domain.Models.HelpWord.Answer>().ReverseMap();
            CreateMap<Category, Domain.Models.HelpWord.Category>().ReverseMap();
            CreateMap<Language, Domain.Models.Languages.Language>().ReverseMap();
            CreateMap<Filter, Domain.Models.Filters.Filter>().ReverseMap();
            CreateMap<UserStatus, Domain.Models.Status>().ReverseMap();
            CreateMap<User, Domain.Models.User>().ReverseMap();
        }
    }
}
