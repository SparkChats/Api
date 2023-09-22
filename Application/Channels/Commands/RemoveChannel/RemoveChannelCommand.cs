﻿using MediatR;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Sparkle.Application.Models;

namespace Sparkle.Application.Channels.Commands.RemoveChannel
{
    public class RemoveChannelCommand : IRequest
    {
        /// <summary>
        /// Id of the channel to be removed 
        /// </summary>
        [DefaultValue("5f95a3c3d0ddad0017ea9291")]
        public string ChatId { get; init; }
    }
}