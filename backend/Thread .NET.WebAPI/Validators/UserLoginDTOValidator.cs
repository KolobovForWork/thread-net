﻿using FluentValidation;
using Thread_.NET.Common.DTO.User;

namespace Thread_.NET.Validators
{
    public sealed class UserLoginDTOValidator : AbstractValidator<UserLoginDTO>
    {
        public UserLoginDTOValidator()
        {
            RuleFor(u => u.Username).NotNull();
            RuleFor(u => u.Password).NotNull();
        }
    }
}
