using System.IO;

namespace Lightweight.Kit.Extensions
{
    public static class StreamExtensions
    {
        public static byte[] ToByteArray(this Stream input)
        {
            using MemoryStream memoryStream = new();

            input.CopyTo(memoryStream);

            return memoryStream.ToArray();
        }
    }
}