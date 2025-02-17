﻿using System;
using System.Collections.Generic;

namespace _2301B2TempEmbedding.Models;

public partial class User
{
    internal readonly int roleId;

    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;
    public int RoleId { get; internal set; }
}
