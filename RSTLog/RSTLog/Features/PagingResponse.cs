﻿using Microsoft.AspNetCore.Components;
using RSTLog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSTLog.Features
{
    public class PagingResponse<T> where T : class
    {
        
        public List<T> Items { get; set; }
        
        public MetaData MetaData { get; set; }
    }
}
