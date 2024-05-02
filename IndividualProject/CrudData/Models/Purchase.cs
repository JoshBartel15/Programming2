﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CrudData.Models;

public partial class Purchase
{
    public int PurchaseId { get; set; }

    public int OwnerId { get; set; }

    public int CarId { get; set; }

    public string PurchaseDate { get; set; }

    public string SaleDate { get; set; }


    //make an override equals that allows the combobox to load in with the correct owner and car
    public override bool Equals(object obj)
    {
        return obj is Purchase purchase &&
               PurchaseId == purchase.PurchaseId &&
               OwnerId == purchase.OwnerId &&
               CarId == purchase.CarId &&
               PurchaseDate == purchase.PurchaseDate &&
               SaleDate == purchase.SaleDate;
    }

    public override string ToString()
    {
        //return the owner and car name using the car and owner navigation properties
        if (SaleDate != null)
        {
            return $"{Owner} bought {Car} on {PurchaseDate} and sold it on {SaleDate}";
        }
        else
        {
            return $"{Owner} bought {Car} on {PurchaseDate}";
        }
    }
    public virtual Car Car { get; set; }

    public virtual Owner Owner { get; set; }
}