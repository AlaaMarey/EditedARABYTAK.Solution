﻿using Arabytak.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arabytak.Repository.Data.Configurations
{
    public class CarPictureUrlConfig : IEntityTypeConfiguration<CarPictureUrl>
    {
        public void Configure(EntityTypeBuilder<CarPictureUrl> builder)
        {
           builder.Property(c=>c.Id).ValueGeneratedNever();
        }
    }
}
