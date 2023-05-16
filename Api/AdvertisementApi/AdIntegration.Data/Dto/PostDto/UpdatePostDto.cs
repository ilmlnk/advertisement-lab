using AdIntegration.Data.Entities;

namespace AdIntegration.Data.Dto.PostDto;

public record UpdatePostDto
{
    public string Text;
    public List<byte[]>? Photos;
    public SystemUser CreatedByUser;
    public DateTime UpdatedAt;
}
