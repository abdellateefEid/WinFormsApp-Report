﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp_Report.Models;

[PrimaryKey("Username", "Password")]
[Table("login_table")]
public partial class LoginTable
{
    [Key]
    [Column("username")]
    [StringLength(100)]
    public string Username { get; set; }

    [Key]
    [Column("password")]
    [StringLength(10)]
    public string Password { get; set; }

    [Required]
    [Column("type")]
    [StringLength(50)]
    public string Type { get; set; }
}