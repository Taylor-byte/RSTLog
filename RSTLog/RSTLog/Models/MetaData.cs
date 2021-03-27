using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSTLog.Models
{
    public class MetaData
    {

        public int CurrentPage { get; set; }

        public int TotalPages { get; set; }

        public int PageSize { get; set; }

        public int TotalCount { get; set; }

        public bool HasPrevious => CurrentPage > 1;

        public bool HasNext => CurrentPage < TotalPages;

        //public int PageCount { get; set; }
        //public int TotalItemCount { get; set; }
        //public int PageNumber { get; set; }
        //public int PageSize { get; set; }
        //public bool HasPreviousPage { get; set; }
        //public bool HasNextPage { get; set; }
        //public bool IsFirstPage { get; set; }
        //public bool IsLastPage { get; set; }
        //public int FirstItemOnPage { get; set; }
        //public int LastItemOnPage { get; }



    }
}
