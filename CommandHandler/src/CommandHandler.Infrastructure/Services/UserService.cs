using System;
using System.Threading.Tasks;
using CommandHandler.Domain.Domain;
using CommandHandler.Domain.Repositories;
using CommandHandler.Infrastructure.DTO;

namespace CommandHandler.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository repository)
        {
            _userRepository = repository;
        }

        public async Task<UserDto> GetAsync(string email)
        {
            var user = await _userRepository.GetAsync(email);
            if (user == null)
            {
                throw new Exception($"User with email: '{email}' doesn't exists.");
            }

            UserDto userDto = new UserDto()
            {
                Email = user.Email,
                FullName = user.FullName,
                Username = user.Username
            };

            return userDto;
        }

        public async Task RegisterAsync(string email, string password, string username)
        {
            var user = await _userRepository.GetAsync(email);
            if (user != null)
            {
                throw new Exception($"User with email: '{email}' already exists.");
            }

            var salt = Guid.NewGuid().ToString("N");
            user = new User(email, username, password, salt);
            await _userRepository.AddAsync(user);
        }
    }
}