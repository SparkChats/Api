﻿using MediatR;

namespace Sparkle.Application.Models.Events
{
    public record FriendRequestEvent(Relationship Relationship) : INotification;
    public record RelationshipDeletedEvent(Relationship Relationship) : INotification;
    public record RelationshipUpdatedEvent(Relationship Relationship) : INotification;
    public record UserUpdatedEvent(User User) : INotification;
}
