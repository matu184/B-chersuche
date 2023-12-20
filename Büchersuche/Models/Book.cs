using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;

namespace Büchersuche.Models
{
    public partial class Book
    {
        public string Isbn { get; set; } = null!;
        public string Title { get; set; } = null!;
        public DateTime Year { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; } = null!;

    }


}
