﻿using AutoMapper;
using MediatR;
using Sparkle.Application.Common.Exceptions;
using Sparkle.Application.Common.Interfaces;
using Sparkle.Application.Common.Interfaces.Repositories;
using Sparkle.Application.Models;
using Sparkle.Application.Models.LookUps;

namespace Sparkle.Application.Messages.Commands.AddMessage
{
    public class AddMessageCommandHandler : RequestHandlerBase, IRequestHandler<AddMessageCommand, MessageDto>
    {
        private readonly IUserProfileRepository _userProfileRepository;
        private readonly IServerProfileRepository _serverProfileRepository;

        public async Task<MessageDto> Handle(AddMessageCommand request, CancellationToken cancellationToken)
        {
            Context.SetToken(cancellationToken);

            Chat chat = await Context.Chats.FindAsync(request.ChatId, cancellationToken);
            UserProfile profile;
            if (chat is Channel channel)
            {
                profile = await _serverProfileRepository.FindUserProfileOnServerAsync(channel.ServerId, UserId, cancellationToken)
                    ?? throw new EntityNotFoundException(message: $"User {UserId} profile not found in server {channel.ServerId}", "");

            }
            else
                profile = await _userProfileRepository.FindByChatIdAndUserIdAsync(chat.Id, UserId, cancellationToken);

            List<Attachment> attachments = new();

            AttachmentsFromText.GetAttachments(request.Text, a => attachments.Add(a));

            request.Attachments?.ForEach(a =>
            {
                attachments.Add(new Attachment
                {
                    IsInText = false,
                    Path = a.Path,
                    IsSpoiler = a.IsSpoiler
                });
            });

            Message message = new()
            {
                Text = request.Text,
                ChatId = request.ChatId,
                SendTime = DateTime.UtcNow,
                Author = profile.Id,
                Attachments = attachments
            };

            await Context.Messages.AddAsync(message, cancellationToken);

            return Mapper.Map<MessageDto>(message);
        }

        public AddMessageCommandHandler(IAppDbContext context, IAuthorizedUserProvider userProvider, IMapper mapper, IUserProfileRepository userProfileRepository, IServerProfileRepository serverProfileRepository) :
            base(context, userProvider, mapper)
        {
            _userProfileRepository = userProfileRepository;
            _serverProfileRepository = serverProfileRepository;
        }
    }
}