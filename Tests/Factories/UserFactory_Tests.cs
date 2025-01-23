using Application.Factories;
using Application.Dtos;
using Application.Models;

namespace Tests.Factories;
public class UserFactory_Tests
{

    [Fact]
    public void Create_ShouldReturnUserRegistrationForm() 
    {
        // Act
        var result = UserFactory.Create();

        // Assert
        Assert.NotNull(result);
        Assert.IsType<UserRegistrationForm>(result);
    }

    [Fact]
    public void Create_ShouldReturnUser_WhenUserRegistrationFormIsProvided()
    {
        // Act
        var userRegistrationForm = new UserRegistrationForm()
        {
            FirstName = "Shane",
            LastName = "Doe",
            Email = "ShaneDoe@gmail.com"
        };

        // Act
        var result = UserFactory.Create(userRegistrationForm);

        // Assert
        Assert.NotNull(result);
        Assert.IsType<User>(result);
        Assert.Equal(userRegistrationForm.FirstName, result.FirstName);
        Assert.Equal(userRegistrationForm.LastName, result.LastName);
        Assert.Equal(userRegistrationForm.Email, result.Email);


    }


}

   
