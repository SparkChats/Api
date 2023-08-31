﻿using System.ComponentModel;
using MediatR;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;

namespace Application.Queries.GetServerDetails
{
    public record GetServerDetailsRequest : IRequest<ServerDetailsDto>
    {
        [Required]
        [StringLength(24, MinimumLength = 24)]
        [DefaultValue("5f95a3c3d0ddad0017ea9291")]
        public string ServerId { get; init; }
    }
}
