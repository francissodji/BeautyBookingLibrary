using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingLibrary.Dtos
{
    public class CatalogLibraryReadDto
    {
        public int IdCatalog { get; set; }

        public string? ImageLink { get; set; }

        public int IdStyle { get; set; }

        public int IdCompany { get; set; }
    }
}
