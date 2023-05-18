using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdIntegration.Data.Entities.Telegram;

[Table(nameof(TelegramChannel))]
public class TelegramChannel : Channel
{
    [Required]
    public string ChannelUrl { get; set; }
    [Required]
    public bool IsSuperGroup { get; set; }
    [Required]
    public bool IsBroadcast { get; set; }
    [Required]
    public string InviteLink { get; set; }
}
