﻿using Application.Common.Exceptions;
using Application.Interfaces;
using Application.Models;
using Application.Providers;
using AutoMapper;
using MediatR;
using MongoDB.Driver;

namespace Application.Commands.Messages.AddReaction
{
    public class AddReactionRequestHandler : RequestHandlerBase, IRequestHandler<AddReactionRequest>
    {
        public async Task Handle(AddReactionRequest request, CancellationToken cancellationToken)
        {
            Context.SetToken(cancellationToken);

            Message message = await Context.Messages.FindAsync(request.MessageId);
            Chat chat = await Context.Chats.FindAsync(message.ChatId);
            User user = await Context.FindSqlByIdAsync<User>(UserId, cancellationToken);

            if (!chat.Users.Any(u => u.Id == UserId))
                throw new NoPermissionsException("You are not a member of the Chat");

            Reaction reaction = new()
            {
                User = Mapper.Map<UserLookUp>(user),
                Emoji = request.Emoji,
            };

            await Context.Messages.UpdateAsync(message);
        }

        public AddReactionRequestHandler(IAppDbContext context, IAuthorizedUserProvider userProvider, IMapper mapper) :
            base(context, userProvider, mapper)
        {
        }
    }
}