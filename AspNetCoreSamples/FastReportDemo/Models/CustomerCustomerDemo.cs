﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace FastReportDemo.Models
{
    [Table("CustomerCustomerDemo")]
    public partial class CustomerCustomerDemo
    {
        [Key]
        [Column("CustomerID")]
        [StringLength(5)]
        public string CustomerId { get; set; }
        [Key]
        [Column("CustomerTypeID")]
        [StringLength(10)]
        public string CustomerTypeId { get; set; }

        [ForeignKey(nameof(CustomerId))]
        [InverseProperty("CustomerCustomerDemos")]
        public virtual Customer Customer { get; set; }
        [ForeignKey(nameof(CustomerTypeId))]
        [InverseProperty(nameof(CustomerDemographic.CustomerCustomerDemos))]
        public virtual CustomerDemographic CustomerType { get; set; }
    }
}
