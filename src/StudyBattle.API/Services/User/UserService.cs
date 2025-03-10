﻿using AutoMapper;
using StudyBattle.API.Repostories.Interfaces.GenericRepository;
using StudyBattle.API.Services.Generic;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TaskSystem.Core.Domain.DTOs.UserDTO;
using TaskSystem.Core.Domain.DTOs.UserDTO;
using TaskSystem.Core.Domain.Models.User;
using TaskSystem.Repostories.Interfaces.UserRepository;
using TaskSystem.Services.Interfaces.ICommon;
using TaskSystem.Services.Interfaces.User;

namespace TaskSystem.Services.UserService
{
    public class UserService : GenericService<UserEntity, UserRequestDTO, UserUpdateDTO, UserResponseDTO>, IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly ICommonService _commonService;

        public UserService(
            IGenericRepository<UserEntity> repository, 
            IMapper mapper,
            IUserRepository userRepository, 
            ICommonService commonService
        ) : base(repository, mapper)
        {
            _userRepository = userRepository;
            _commonService = commonService;
        }

        // Método específico para User
        public async Task<UserResponseDTO> AddUserAsync(UserRequestDTO user)
        {
            try
            {
                if (user == null)
                {
                    throw new ArgumentException("User data cannot be null");
                }

                var emailValidation = _commonService.IsValidEmail(user.Email);
                if (!emailValidation)
                {
                    throw new ArgumentException("Invalid email format");
                }

                bool existsEmail = await _userRepository.ExistsEmailAsync(user.Email);
                if (existsEmail)
                {
                    throw new ArgumentException("There is already a user with this email");
                }

                string hashedPassword = _commonService.PasswordEncoder(user.UserPassword);

                var newUser = new UserRequestDTO
                {
                    Email = user.Email,
                    UserPassword = hashedPassword,
                    Name = user.Name
                };

                return await CreateAsync(newUser);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while adding the user.", ex);
            }
        }

        public async Task<bool> ExistsEmailAsync(string email)
        {
            return await _userRepository.ExistsEmailAsync(email);
        }
    }
}