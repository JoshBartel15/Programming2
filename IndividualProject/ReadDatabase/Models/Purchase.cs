﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ReadDatabase.Models;

public partial class Purchase
{ 
    public int PurchaseId { get; set; }

    public int OwnerId { get; set; }

    public int CarId { get; set; }

    public string PurchaseDate { get; set; }

    public string SaleDate { get; set; }

    public Purchase(Car car, Owner owner)
    {
        if (car == null)
        {
            throw new ArgumentNullException(nameof(car));
        }
        if (owner == null)
        {
            throw new ArgumentNullException(nameof(owner));
        }
        int carid = car.CarId;
        int ownerid = owner.OwnerId;
        PurchaseDate = string.Empty;
        SaleDate = string.Empty;
    }
    public Purchase()
    {
        //make sure to set the carid and ownerid to the carid and ownerid of the car and owner that are passed in
        PurchaseId = 0;
        OwnerId = 0;
        CarId = 0;
        PurchaseDate = string.Empty;
        SaleDate = string.Empty;
        }

    public Purchase(int carid, int ownerid)
    {
        CarId = carid;
        OwnerId = ownerid;
    }
    public override string ToString()
    {
        return $" Purchase Date: {PurchaseDate} Sale Date: {SaleDate}";
    }
    public virtual Car car { get; set; }

    public virtual Owner Owner { get; set; }

}