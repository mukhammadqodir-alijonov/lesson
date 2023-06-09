﻿using CarShop.Api.Common.Enums;

namespace CarShop.Api.Models;
public class User
{
    public long Id { get; set; }

    public string FirstName { get; set; } = String.Empty;

    public string LastName { get; set; } = String.Empty;

    public string Email { get; set; } = String.Empty;

    public string ImagePath { get; set; } = String.Empty;

    public string PasswordHash { get; set; } = String.Empty;

    public string Salt { get; set; } = String.Empty;

    public UserRole Role { get; set; } = UserRole.User;
}
