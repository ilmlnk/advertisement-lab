using AdIntegration.Business.Services;
using AdIntegration.Data.Dto.ChannelDto.Add;
using AdIntegration.Data.Dto.ChannelDto.Update;
using AdIntegration.Data.Entities.Telegram;
using AdIntegration.Data.Entities.Viber;
using AdIntegration.Data.Entities.WhatsApp;
using AdIntegration.Repository.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AdIntegration.Api.Controllers.Channels;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class TelegramChannelController : ControllerBase
{

}
