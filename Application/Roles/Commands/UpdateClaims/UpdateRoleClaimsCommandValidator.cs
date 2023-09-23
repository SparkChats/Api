﻿using FluentValidation;
using Sparkle.Application.Roles.Common.Validation;

namespace Sparkle.Application.Roles.Commands.UpdateClaims
{
    public class UpdateRoleClaimsCommandValidator : AbstractValidator<UpdateRoleClaimsCommand>
    {
        public UpdateRoleClaimsCommandValidator()
        {
            RuleFor(c => c.RoleId).NotNull();

            RuleFor(c => c.Claims).NotNull();
            RuleForEach(c => c.Claims).SetValidator(new ClaimValidator());
        }
    }
}
