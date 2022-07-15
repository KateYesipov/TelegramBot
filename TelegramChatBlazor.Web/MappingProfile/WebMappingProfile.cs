using AutoMapper;
using TelegramChatBlazor.Domain.Models.Api;
using TelegramChatBlazor.Domain.Models.Messages;
using TelegramChatBlazor.Domain.Models.SignalR;

namespace TelegramChatBlazor.Web.MappingProfile
{
    public class WebMappingProfile : Profile
    {
        public WebMappingProfile()
        {
            CreateMap<MessageRequest, Message>().ReverseMap();
            CreateMap<ChatNotification, MessageRequest>()
                .ForMember(dest => dest.Text, e => e.MapFrom(src => src.Message.Text))
                 .ForMember(dest => dest.Type, e => e.MapFrom(src => src.Message.Type))
                 .ForMember(dest => dest.MessageId, e => e.MapFrom(src => src.Message.Id))
                 .ForMember(dest => dest.IsPartner, e => e.MapFrom(src => src.Message.IsPartner))
                 .ForMember(dest => dest.MessageGroupId, e => e.MapFrom(src => src.Message.MessageGroupId))
                 .ForMember(dest => dest.FileId, e => e.MapFrom(src => src.Message.FilePath))
                 .ForMember(dest => dest.ChatId, e => e.MapFrom(src => src.Message.ChatId)).ReverseMap();
        }
    }
}
