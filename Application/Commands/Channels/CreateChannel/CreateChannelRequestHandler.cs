﻿using Application.Interfaces;
using Application.Models;
using Application.Providers;
using AutoMapper;
using MediatR;

namespace Application.Commands.Channels.CreateChannel
{
    public class CreateChannelRequestHandler : RequestHandlerBase, IRequestHandler<CreateChannelRequest, string>
    {
        public async Task<string> Handle(CreateChannelRequest request, CancellationToken cancellationToken)
        {
            Context.SetToken(cancellationToken);

            //TODO: Перевірити що у юзера є відповідні права
            Server server = await Context.Servers.FindAsync(request.ServerId);
            List<UserLookUp> users = new();
            server.ServerProfiles.ForEach(profile => users.Add(Mapper.Map<UserLookUp>(profile.User)));
            Channel channel = new()
            {
                Title = request.Title,
                Users = users,
                ServerId = server.Id
            };

            return (await Context.Channels.AddAsync(channel)).Id;
        }

        public CreateChannelRequestHandler(IAppDbContext context, IAuthorizedUserProvider userProvider, IMapper mapper)
            : base(context, userProvider, mapper)
        {
        }
    }
}