﻿using System;

namespace Password.Desktop.Win.Data.Migration
{
    public class MigrationsHistory
    {
        public const byte IndexNumber = 0;
        protected MigrationsHistory()
        {
        }

        public MigrationsHistory(int number, string fullName)
        {
            Number = number;
            FullName = fullName;
        }

        public int Id { get; set; }
        public int Number { get; set; }
        public string FullName { get; set; }
        public DateTime DataCreated { get; set; }
        public string FullPatch { get; set; }
        public string CreateScript => $"INSERT INTO MigrationsHistory ({nameof(Number)}, {nameof(FullName)}, {nameof(DataCreated)}) VALUES({Number}, '{FullName}', datetime());";
    }
}