﻿using Microsoft.EntityFrameworkCore;

namespace Password.Desktop.Win.Data.Migration
{
    public static class ModelBuilderExtensions
    {
        public static void UseMigrationsHistory(this ModelBuilder builder)
        {
            builder.ApplyConfiguration(new MigrationsHistoryConfiguration());
        }
    }
}