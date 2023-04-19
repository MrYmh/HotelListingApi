﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelLisstingApi.Core.Dtos
{
    public class QueryParameters
    {
        private int _pageSize = 15;
        public int StartIndex { get; set; }
        public int PageNumber { get; set; }
        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = value;
            }
        }
    }
}
