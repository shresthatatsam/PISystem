using Microsoft.AspNetCore.Mvc;

namespace PISystem.Models.Interface
{
    public interface IUserInformation
    {
        UserInformationViewModel Model { get; set; }
        IActionResult Register();
        bool Login(string userName, string password);
    }
}
