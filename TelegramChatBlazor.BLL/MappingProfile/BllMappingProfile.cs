using AutoMapper;
using TelegramChatBlazor.Domain.Models.Chats;

namespace TelegramChatBlazor.BLL.MappingProfile
{
    public class BllMappingProfile : Profile
    {
        public BllMappingProfile()
        {
            CreateMap<SelectChat, Chat>().ReverseMap();
        }
    }
}
