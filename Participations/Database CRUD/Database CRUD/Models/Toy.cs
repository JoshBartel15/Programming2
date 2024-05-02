﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Database_CRUD.Models;

public partial class Toy
{
    public Toy()
    {
        DogToys = new HashSet<DogToy>();
    }

    public Toy(ToyInput t) : this()
    {
        Name = t.Name;
        Image = t.Image;
        if (t.HasSqueaker.ToLower()[0] == 'y')
        {
            HasSqueeker = true;
        }
        else
        {
            HasSqueeker = false;
        }
    }
    public int Id { get; set; }

    public string Name { get; set; }

    public string Image { get; set; }

    public bool HasSqueeker { get; set; }
    public override string ToString()
    {
        return Name;
    }
    public virtual ICollection<DogToy> DogToys { get; set; } = new List<DogToy>();
}