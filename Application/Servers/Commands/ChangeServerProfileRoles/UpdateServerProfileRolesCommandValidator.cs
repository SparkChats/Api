﻿using FluentValidation;

namespace Sparkle.Application.Servers.Commands.ChangeServerProfileRoles
{
    public class UpdateServerProfileRolesCommandValidator : AbstractValidator<UpdateServerProfileRolesCommand>
    {
        public UpdateServerProfileRolesCommandValidator()
        {
            RuleFor(x => x.ProfileId).NotNull();
            RuleFor(x => x.Roles).NotNull();
        }
    }
}
