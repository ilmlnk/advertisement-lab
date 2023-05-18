using AdIntegration.Data.Entities;

namespace AdIntegration.Data.Dto.AdminTaskDto;

public record UpdateAdminTaskDto
{
    public string Name;
    public string Topic;
    public string? Description;
    public string Status;
    public int? Priority;
    public DateTime CreatedAtDate;
    public DateTime? DueToDate;
    public SystemUser AssignedTo;
    public List<Tag>? Tags;
    public List<Comment>? Comments;
}
