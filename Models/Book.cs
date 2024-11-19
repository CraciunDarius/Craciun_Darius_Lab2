﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Craciun_Darius_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Display(Name = "Book Title")]
        [Required(ErrorMessage = "Este obligatorie introducerea unui titlu!")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "Titlul trebuie sa fie cuprins intre 3 si 150 de caractere")]
        public string Title { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        [Range(0.01, 500)]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }

        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; }

        public int? AuthorID { get; set; }
        public Author? Author { get; set; }

        public ICollection<Borrowing>? Borrowings { get; set; }
        public ICollection<BookCategory>? BookCategories { get; set; }


    }
}