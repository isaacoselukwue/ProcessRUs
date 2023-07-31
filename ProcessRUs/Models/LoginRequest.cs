using System;
namespace ProcessRUs.Models;

public class LoginRequest
{
    public string UserName { get; set; }
    public string Password { get; set; }
}