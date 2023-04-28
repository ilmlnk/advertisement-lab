using AdIntegration.Data.Dto;
using AdIntegration.Data.Entities;
using AdIntegration.Data.Entities.Telegram;
using AdIntegration.Data.Entities.Viber;
using AdIntegration.Data.Entities.WhatsApp;
using AdIntegration.Repository.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AdIntegration.Api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ChannelController<T, V> : ControllerBase where T : User where V : Channel<T>
    {
        private readonly IChannelRepository<T, V> _channelRepository;

        public ChannelController(IChannelRepository<T, V> channelRepository)
        {
            _channelRepository = channelRepository;
        }

        [HttpPost("telegram/add")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult AddTelegramChannel(AddTelegramChannelDto dto)
        {
            var createdChannel = new TelegramChannel<T, V>
            {

            };
            return Ok();
        }

        [HttpPost("viber/add")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult AddViberChannel(AddViberChannelDto dto)
        {
            var createdChannel = new ViberChannel<T, V>
            {

            };

            return Ok();
        }

        [HttpPost("whatsapp/add")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult AddWhatsAppChannel(AddWhatsAppChannelDto dto)
        {
            var createdChannel = new WhatsAppChannel<T, V>
            { 

            };

            return Ok();
        }

        [HttpPost("edit/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult EditViberChannel(int id, UpdateViberChannelDto dto)
        {
            var viberChannel = _channelRepository.GetChannelById<ViberChannel<T, V>>(id);

            if (viberChannel == null)
            {
                return BadRequest();
            }

            var editedChannel = new ViberChannel<T, V>
            {

            };

            return Ok();
        }

        [HttpPost("edit/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult EditTelegramChannel(int id, UpdateTelegramChannelDto dto)
        {
            var editedChannel = new TelegramChannel<T, V>
            { 

            };

            return Ok();
        }

        [HttpPost("edit/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult EditWhatsAppChannel(int id, UpdateWhatsAppChannel dto)
        {
            var whatsAppChannel = _channelRepository.GetChannelById<WhatsAppChannel<T, V>>(id);
            var editedChannel = new WhatsAppChannel<T, V> 
            {
                Name = dto.Name,
                Description = dto.Description,
                Photo = dto.Photo,
                IsPrivate = dto.IsPrivate,
                Email = dto.Email,
                UrlAddress = dto.UrlAddress,
                Category = dto.Category,
                Subcategory = dto.Subcategory
            };

            return Created("success", 
                _channelRepository.UpdateChannelById(id, editedChannel));
        }

        [HttpDelete("delete/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteWhatsAppChannel(int id)
        {
            _channelRepository.DeleteChannelById<WhatsAppChannel<T, V>>(id);
            return NoContent();
        }

        [HttpDelete("delete/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteViberChannel(int id)
        {
            _channelRepository.DeleteChannelById<ViberChannel<T, V>>(id);
            return NoContent();
        }

        [HttpDelete("delete/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteTelegramChannel(int id)
        {
            _channelRepository.DeleteChannelById<TelegramChannel<T, V>>(id);
            return NoContent();
        }
    }
}
