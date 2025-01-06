﻿using System.ComponentModel.DataAnnotations;

namespace session03.Model;

class User
{
    public int ID { get; set; }
    [Display(Name = "نام")]
    public string Name { get; set; }
    public string Family { get; set; }
    public string Email { get; set; }
    public bool IsActive { get; set; }

    private string password;

    public User()
    {
        password = "yechizi";
    }
}