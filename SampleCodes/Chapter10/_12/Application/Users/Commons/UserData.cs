﻿using _12.Domain.Models.Users;

namespace _12.Application.Users.Commons
{
    public class UserData
    {
        public UserData(User user) : this(user.Id.Value, user.Name.Value)
        {
        }

        public UserData(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Id { get; }
        public string Name { get; }
    }
}
