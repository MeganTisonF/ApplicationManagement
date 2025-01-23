
using Application.Dtos;
using Application.Helpers;
using Application.Models;

namespace Application.Factories;

public static class UserFactory
{
    public static UserRegistrationForm Create() => new();

    public static User Create(UserRegistrationForm form) => new()
    {
        Id = IdGenerator.Generate(),
        FirstName = form.FirstName,
        LastName = form.LastName,
        Email = form.Email,

    };
}
