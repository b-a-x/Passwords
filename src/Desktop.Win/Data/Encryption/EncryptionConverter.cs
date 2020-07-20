﻿using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Desktop.Win.Data.Encryption
{
    internal sealed class EncryptionConverter : ValueConverter<string, string>
    {
        public EncryptionConverter(IEncryptionProvider encryptionProvider, ConverterMappingHints mappingHints = null)
            : base(x => encryptionProvider.Encrypt(x), x => encryptionProvider.Decrypt(x), mappingHints)
        {
        }
    }
}