﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RGB.Back.Models;

public partial class TransferRefund
{
    public int Id { get; set; }

    public int TransferMethodsId { get; set; }

    public int TransferPaymentId { get; set; }

    public DateTime RefundDate { get; set; }

    public decimal RefundAmount { get; set; }

    public virtual TransferPayment Id1 { get; set; }

    public virtual TransferMethod IdNavigation { get; set; }
}