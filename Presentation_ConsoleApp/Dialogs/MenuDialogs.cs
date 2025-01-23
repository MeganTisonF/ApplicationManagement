using Application.Factories;
using Application.Interfaces;

namespace Presentation_ConsoleApp.Dialogs
{
    public class MenuDialogs
    {
        private readonly IUserService _userService;

        public MenuDialogs(IUserService userService)
        {
            _userService = userService;
        }

        public void MainMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("-- Menu options --");
                Console.WriteLine("1. Add User");
                Console.WriteLine("2. View All Users");
                Console.WriteLine();
                Console.WriteLine("Select Option");
                var option = Console.ReadLine()!;

                switch (option)
                {
                    case "1":
                        AddUserOption();
                        break;

                    case "2":
                        ViewAllUsersOptions();
                        break;
                }
            }
        }

        public void AddUserOption()
        {
            var form = UserFactory.Create();

            Console.Clear();
            Console.WriteLine("-- New users --");
            Console.WriteLine("First Name: ");
            form.FirstName = Console.ReadLine()!;
            Console.WriteLine("Last Name: ");
            form.LastName = Console.ReadLine()!;
            Console.WriteLine("Email: ");
            form.Email = Console.ReadLine()!;

            var result = _userService.Save(form);
            if (result)
                Console.Write("User was created successfully");
            else
                Console.WriteLine("User was not created");

            Console.ReadKey();
        }

        public void ViewAllUsersOptions()
        {
            Console.Clear();
            Console.WriteLine("-- View all users --");

            var users = _userService.GetAllt();
            foreach (var user in users)
            {
                Console.WriteLine($"{user.FirstName} {user.LastName} <{user.Email}>");
            }
            Console.ReadKey();
        }
    }
}
