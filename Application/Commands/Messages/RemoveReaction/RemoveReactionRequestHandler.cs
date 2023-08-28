﻿using Application.Exceptions;
using Application.Interfaces;
using Application.Models;
using MediatR;
using MongoDB.Driver;

namespace Application.Commands.Messages.RemoveReaction
{
    public class RemoveReactionRequestHandler : RequestHandlerBase, IRequestHandler<RemoveReactionRequest, Message>
    {
        public async Task<Message> Handle(RemoveReactionRequest request, CancellationToken cancellationToken)
        {
            Context.SetToken(cancellationToken);
            
            Message message = await Context.Messages.FindAsync(request.MessageId);
            Reaction reaction = message.Reactions[request.ReactionIndex];

            if (reaction.User.Id != UserId)
                throw new NoPermissionsException("This isn't your reaction");

            message.Reactions.RemoveAt(request.ReactionIndex);
            await Context.Messages.UpdateAsync(message);
            return message;
        }

        public RemoveReactionRequestHandler(IAppDbContext context, IAuthorizedUserProvider userProvider) : base(context,
            userProvider)
        {
        }
    }
}