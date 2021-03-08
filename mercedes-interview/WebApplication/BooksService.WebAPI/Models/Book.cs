﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace BooksService.WebAPI.Models
{
    public class CustomDateRangeAttribute : RangeAttribute
    {
        public CustomDateRangeAttribute() : base(typeof(DateTime), "1/1/1900", DateTime.Now.ToString())
        { }
    }
    public class Book
    {


        [ScaffoldColumn(true)]
        [Required]
        [StringLength(maximumLength: 255, ErrorMessage = "Title is invalid: Title must contain a minimum of 5 characters and a maximum of 255, and the first letter should be in upper case", MinimumLength =5)]
        [RegularExpression("/^[A-Z][a-z0-9_-]{3,19}$/",
            ErrorMessage = "Title is invalid: Title must contain a minimum of 5 characters and a maximum of 255, and the first letter should be in upper case")]
        public string Title { get; set; }

        [ScaffoldColumn(true)]
        [Required]
        [StringLength(maximumLength: 30, ErrorMessage =
            "Author is invalid: Author must contain a minimum of 3 characters and a maximum of 30, and the first letter should be in upper case", MinimumLength = 3)]
        [RegularExpression("/^[A-Z][a-z0-9_-]{3,19}$/",
    ErrorMessage = "Author is invalid: Author must contain a minimum of 3 characters and a maximum of 30, and the first letter should be in upper case")]
        public string Author { get; set; }


        [Required]
        [DataType(DataType.DateTime), Timestamp, ScaffoldColumn(false)]

        [Range(typeof(DateTime), "1/1/1900", "3/6/2021",
        ErrorMessage = "PublicationDate is invalid: PublicationDate must be after 01/01/1900 and before the current date")]
        public DateTime PublicationDate { get; set; }
    }
}