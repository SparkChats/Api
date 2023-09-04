﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Application.Models;
using MediatR;

namespace Application.Commands.Users.SendMessageToUser
{
    public record SendMessageToUserRequest : IRequest<MessageChatDto>
    {
        [DefaultValue(1)]
        public int UserId { get; init; }
        
        [MaxLength(2000)]
        [DefaultValue("MessageText")]
        public string Text { get; init; }
        
        public List<Attachment>? Attachments { get; init; }
    }
}