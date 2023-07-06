using AdIntegration.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Data.Dto;

public record DeleteMessageDto
{
    public string DeleteType;
    public Message Message;
    public string DeletedUserId;
}
