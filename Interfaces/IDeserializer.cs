﻿using System;
using System.Threading.Tasks;

namespace AsyncProtoStream.Serialization
{
    public interface IDeserializer
    {
        T FromFile<T>(
            string filePath,
            bool gzipDecompress = false);

        Task<T> FromFileAsync<T>(
            string filePath,
            bool gzipDecompress = false);

        T FromByteArray<T>(
            byte[] value,
            bool gzipDecompress = false);

        T FromStringValue<T>(
            string value,
            bool gzipDecompress = false);
    }
}
