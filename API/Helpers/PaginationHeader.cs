using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Helpers
{
    public class PaginationHeader
    {
        public PaginationHeader(int currentPage, int itemsPerpage, int totalPages, int totalPages1)
        {
            CurrentPage = currentPage;
            ItemsPerpage = itemsPerpage;
            TotalPages = totalPages;
        }

        public int CurrentPage { get; set; }
        public int ItemsPerpage { get; set; }
        public int TotalPages { get; set; }
    }
}