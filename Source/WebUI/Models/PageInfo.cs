using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Models
{
    public class PageInfo
    {
        public int TotalProducts { get; set; }
        public int TotalPages
        {
            get
            {
                if (TotalProducts % PageSize == 0)
                    return TotalProducts / PageSize;
                else
                    return (TotalProducts / PageSize) + 1;
            }
        }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
    }
}