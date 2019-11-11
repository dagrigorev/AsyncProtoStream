using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace AsyncProtoStream.Interfaces
{
    public interface ISerializer
    {
        string SaveToFile(
            object item,
            string filePath,
            FileMode fileMode = FileMode.Create,
            bool gzipCompress = false);

        Task<string> SaveToFileAsync(
            object item,
            string filePath,
            FileMode fileMode = FileMode.Create,
            bool gzipCompress = false);

        byte[] ToByteArray(
            object item,
            bool gzipCompress = false);

        string ToStringValue(
            object item,
            bool gzipCompress = false);
    }
}
