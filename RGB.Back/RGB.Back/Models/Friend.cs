﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RGB.Back.Models;

public partial class Friend
{
    public int Id { get; set; }

    public int Member1Id { get; set; }

    public int Member2Id { get; set; }

    public string Relationship { get; set; }

    public virtual Member Member1 { get; set; }

    public virtual Member Member2 { get; set; }
}