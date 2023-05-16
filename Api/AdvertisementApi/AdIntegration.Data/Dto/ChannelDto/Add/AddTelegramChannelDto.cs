namespace AdIntegration.Data.Dto.ChannelDto.Add
{
    public record AddTelegramChannelDto
    {
        public string Name;
        public string? Description;
        public byte[]? Photo;
        public bool IsPrivate;
        public string ChannelUrl;
        public string InviteLink;
    }
}
