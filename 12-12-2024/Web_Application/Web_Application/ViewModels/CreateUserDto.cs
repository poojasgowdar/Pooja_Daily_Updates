﻿namespace Web_Application.ViewModels
{
    public class CreateUserDto
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }
}
