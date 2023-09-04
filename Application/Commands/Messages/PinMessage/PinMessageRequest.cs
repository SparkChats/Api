﻿namespace Application.Commands.Messages.PinMessage
{
    public record PinMessageRequest : IRequest<Message>
    {
        /// <summary>
        /// Id of the message to be pinned
        /// </summary>
        [Required]
        [StringLength(24, MinimumLength = 24)]
        [DefaultValue("5f95a3c3d0ddad0017ea9291")]
        public string MessageId { get; init; }
    }
}