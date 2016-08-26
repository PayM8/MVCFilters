// <copyright file="ArbitaryModel.cs" company="PayM8">
// Copyright (c) 2016 PayM8. All rights reserved.
// </copyright>
// <summary>Implements the arbitary model class</summary>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCFilters.Models
{
    /// <summary>
    /// A data Model for the arbitary.
    /// </summary>
    public class ArbitraryModel
    {
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        [Required]
        public string StrVal { get; set; }

        /// <summary>
        /// Gets or sets the integer value.
        /// </summary>
        [Required]
        public int integerVal { get; set; }

        /// <summary>
        /// Gets or sets the email adddress.
        /// </summary>
        [EmailAddress]
        [Required]
        public string EmailAdddress { get; set; }

        [Required]
        //this will be a manual business validation
        public DateTime FutureDateOnly { get; set; }
    }
}