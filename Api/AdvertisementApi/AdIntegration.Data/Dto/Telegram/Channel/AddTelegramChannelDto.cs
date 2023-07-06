using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Data.Dto.Telegram.Channel;

public record AddTelegramChannelDto
{
    public string Name;
    public string? Description;
    public string? PhotoUrl;
    public bool IsPrivate;
    public string ChannelUrl;
    public int ActiveUsersCount;
    public int? Posts;
    public string InviteLink;
}
