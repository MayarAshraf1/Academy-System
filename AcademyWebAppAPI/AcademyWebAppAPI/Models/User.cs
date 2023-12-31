﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AcademyWebAppAPI.Models;

[Table("User")]
[Index("IsDeleted", Name = "userIsDeletedIndex")]
public partial class User
{
    [Key]
    public int UserId { get; set; }

    [Required]
    [StringLength(140)]
    public string Username { get; set; }

    [Required]
    [StringLength(70)]
    public string Password { get; set; }

    [Required]
    [StringLength(maximumLength: 300)]
    public string FullName { get; set; }

    [StringLength(300)]
    public string Email { get; set; }

    [Required]
    [StringLength(100)]
    public string PhoneNumber { get; set; }

    public int GroupId { get; set; }

    public long LanguageId { get; set; }

    public int BranchId { get; set; }

    [DefaultValue(true)]
    public bool IsActive { get; set; }

    [DefaultValue(false)]
    public bool IsDeleted { get; set; }

    // Navigation Properties

    [ForeignKey("BranchId")]
    [InverseProperty("Users")]
    public virtual Branch Branch { get; set; }

    [ForeignKey("GroupId")]
    [InverseProperty("Users")]
    public virtual Group Group { get; set; }

    [ForeignKey("LanguageId")]
    [InverseProperty("Users")]
    public virtual Language Language { get; set; }
}