﻿using Application.Interfaces;
using Application.Models;
using AutoMapper;

namespace Application.Commands.Messages.AddMessageRequest
{
    public record AddMessageAttachmentDto
    {
        public AttachmentType Type { get; init; }
        public string Path { get; init; }
        public bool IsSpoiler { get; init; }
    }
}