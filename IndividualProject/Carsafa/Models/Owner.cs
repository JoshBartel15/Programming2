﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Carsafa.Models;

public partial class Owner
{
    public int OwnerId { get; set; }

    public string Name { get; set; }

    public virtual ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();
}