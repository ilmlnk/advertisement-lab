using AdIntegration.Data.Dto;
using AdIntegration.Data.Entities.Telegram;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Channels;

namespace AdIntegration.Api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ChannelController : ControllerBase
    {
        [HttpPost("telegram/add")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult AddTelegramChannel(AddTelegramChannelDto dto)
        {
            var createdChannel = new TelegramChannel
            {

            };
            return Ok();
        }

        [HttpPost("viber/add")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult AddViberChannel(AddViberChannelDto dto)
        {

            return Ok();
        }

        [HttpPost("whatsapp/add")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult AddWhatsAppChannel(AddWhatsAppChannelDto dto)
        {

            return Ok();
        }

        [HttpPost("edit/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult EditChannel()
        {
            return Ok();
        }

        [HttpDelete("delete/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteChannel()
        {
            return NoContent();
        }
    }
}
