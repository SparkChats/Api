﻿using MediatR;
using Sparkle.Application.Common.Interfaces;
using Sparkle.Application.Models;

namespace Sparkle.Application.GroupChats.Commands.RenameGroupChat
{
    public class RenameGroupChatCommandHandler : RequestHandlerBase, IRequestHandler<RenameGroupChatCommand>
    {
        public async Task Handle(RenameGroupChatCommand command, CancellationToken cancellationToken)
        {
            Context.SetToken(cancellationToken);

            GroupChat chat = await Context.GroupChats.FindAsync(command.ChatId);

            chat.Title = command.NewTitle;

            await Context.GroupChats.UpdateAsync(chat);
        }

        public RenameGroupChatCommandHandler(IAppDbContext context) : base(
            context)
        {
        }
    }
}
