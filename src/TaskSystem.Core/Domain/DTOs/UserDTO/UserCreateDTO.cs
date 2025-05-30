﻿
using TaskSystem.Core.Utils.Extensions;

namespace TaskSystem.Core.Domain.DTOs.UserDTO
{
    public record UserCreateDTO
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string UserPassword { get; set; }
        public bool ValidateEmail() => Email.IsValidEmail();
    }
}
