﻿using SwordAndFather.Controllers.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class UserRepository
{
    static List<User> _users = new List<User>();

    public User AddUser(string username, string password)
    {
        var newUser = new User(username, password);

        newUser.Id = _users.Count + 1;

        _users.Add(newUser);

        return newUser;
    }
}
