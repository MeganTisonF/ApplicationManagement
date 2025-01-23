
using Application.Dtos;
using Application.Factories;
using Application.Interfaces;
using Application.Models;
using System.Text.Json;

namespace Application.Services;

public class UserService(IFileService fileService) : IUserService
{
    private readonly IFileService _fileService = fileService;
    private List<User> _users = [];

    public IEnumerable<User> GetAllt()
    {
        var content = _fileService.GetContentFromFile();
        try 
        {
            _users = JsonSerializer.Deserialize<List<User>>(content)!;
        }
        catch 
        {
            _users = [];
        }
        return _users;
    }

    public bool Save(UserRegistrationForm form)
    {
        var user = UserFactory.Create(form);
        _users.Add(user);

        var json = JsonSerializer.Serialize(_users);
        var result = _fileService.SaveContentToFile(json);
        return result;
    }
}
