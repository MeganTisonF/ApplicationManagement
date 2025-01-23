using Application.Dtos;
using Application.Models;

namespace Application.Interfaces;

public interface IUserService
{
    bool Save(UserRegistrationForm form);
    IEnumerable<User> GetAllt();
}
