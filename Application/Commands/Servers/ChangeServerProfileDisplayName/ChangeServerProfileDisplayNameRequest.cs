﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using MediatR;

namespace Application.Commands.Servers.ChangeServerProfileDisplayName
{
    public record ChangeServerProfileDisplayNameRequest : IRequest
    {
        [Required]
        [StringLength(24, MinimumLength = 24)]
        [DefaultValue("5f95a3c3d0ddad0017ea9291")]
        public string ServerId { get; init; } 
        [Required]
        public string NewDisplayName { get; init; }
        [Required]
        [DefaultValue(1)]
        public int? UserId { get; set; }
    }
}