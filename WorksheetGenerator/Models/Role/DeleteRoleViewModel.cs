﻿using MessagePack;
using Microsoft.AspNetCore.Identity;

namespace WorksheetGenerator.Models.Role
{
    public class DetailsRoleViewModel
    {
        public DetailsRoleViewModel()
        {
            UsersInRole = new List<IdentityUser>();
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public List<IdentityUser> UsersInRole { get; set; }
    }
}
