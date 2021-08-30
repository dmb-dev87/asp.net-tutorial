﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApp.Models;

namespace TodoApp.Data
{
    public class ApiDbConext : DbContext
    {
        public DbSet<ItemData> Items { get; set; }

        public ApiDbConext(DbContextOptions<ApiDbConext> options)
            : base(options)
        {

        }
    }
}