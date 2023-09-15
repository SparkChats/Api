﻿using Sparkle.Application.Common.Exceptions;
using Sparkle.Application.Invitations.Queries.GetInvitationDetails;
using Sparkle.Application.Models;
using Sparkle.Tests.Common;

namespace Sparkle.Tests.Invitations
{
    public class GetInvitationDetailsTests : TestBase
    {
        [Fact]
        public async Task Success()
        {
            //Arrange
            CreateDatabase();
            string invitationId = Ids.Invitation1;

            SetAuthorizedUserId(Ids.UserBId);

            GetInvitationDetailsQuery request = new()
            {
                InvitationId = invitationId
            };
            GetInvitationDetailsQueryHandler handler = new(Context, UserProvider, Mapper);

            //Act
            InvitationDetailsDto result = await handler.Handle(request, CancellationToken);
            Invitation invitation = await Context.Invitations.FindAsync(invitationId);

            //Assert
            Assert.Equal(invitation.ServerId, result.Server.Id);
            Assert.NotNull(result.User);
            Assert.NotNull(result.ExpireTime);
            Assert.Equal(invitation.UserId, result.User.Id);
            Assert.Equal(invitation.ExpireTime, result.ExpireTime);
        }
        [Fact]
        public async Task Success_LessParams()
        {
            //Arrange
            CreateDatabase();
            string invitationId = Ids.Invitation2;

            SetAuthorizedUserId(Ids.UserAId);

            GetInvitationDetailsQuery request = new()
            {
                InvitationId = invitationId
            };
            GetInvitationDetailsQueryHandler handler = new(Context, UserProvider, Mapper);

            //Act
            InvitationDetailsDto result = await handler.Handle(request, CancellationToken);
            Invitation invitation = await Context.Invitations.FindAsync(invitationId);

            //Assert
            Assert.Equal(invitation.ServerId, result.Server.Id);
            Assert.Null(result.User);
            Assert.Null(result.ExpireTime);
        }
        [Fact]
        public async Task Fail_InvitationIsExpired()
        {
            //Arrange
            CreateDatabase();
            string invitationId = Ids.Invitation3;
            long oldCount = await Context.Invitations.CountAsync(s => true);

            SetAuthorizedUserId(Ids.UserDId);

            GetInvitationDetailsQuery request = new()
            {
                InvitationId = invitationId
            };
            GetInvitationDetailsQueryHandler handler = new(Context, UserProvider, Mapper);

            //Act
            //Assert
            Invitation invitation = await Context.Invitations.FindAsync(invitationId);
            await Assert.ThrowsAsync<NoPermissionsException>(
                async () => await handler.Handle(request, CancellationToken));
            await Assert.ThrowsAsync<EntityNotFoundException>(
                async () => await Context.Invitations.FindAsync(invitationId));
            Assert.Equal(oldCount - 1, await Context.Invitations.CountAsync(s => true));
        }
    }
}