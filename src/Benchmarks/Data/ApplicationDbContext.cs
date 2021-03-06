﻿// Copyright (c) .NET Foundation. All rights reserved. 
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information. 

using Microsoft.Data.Entity;

namespace Benchmarks.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<World> World { get; set; }

        public DbSet<Fortune> Fortune { get; set; }
    }
}
