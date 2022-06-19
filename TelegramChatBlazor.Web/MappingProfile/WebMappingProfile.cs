using AutoMapper;
using TelegramChatBlazor.Domain.Models;
using TelegramChatBlazor.Domain.Models.Api;
using TelegramChatBlazor.Domain.Models.SignalR;

namespace TelegramChatBlazor.Web.MappingProfile
{
    public class WebMappingProfile : Profile
    {
        public WebMappingProfile()
        {
            CreateMap<MessageRequest, Message>().ReverseMap();
            CreateMap<MessageNotification, MessageRequest>()
                .ForMember(dest => dest.Text, e => e.MapFrom(src => src.Message.Text))
                    .ForMember(dest => dest.IsPartner, e => e.MapFrom(src => src.Message.IsPartner))
                    .ForMember(dest => dest.ChatId, e => e.MapFrom(src => src.Message.ChatId)).ReverseMap();
        }
    }
}
