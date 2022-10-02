using System.IO;
using System.IO.Compression;
using Lightweight.Kit.Zip.Models;

namespace Lightweight.Kit.Zip.Extensions
{
    public static class ZipExtensions
    {
        public static byte[] ToArchive(this List<LightweightFile> files, string pushToFolder = "")
        {
            using MemoryStream memoryStream = new();

            using (ZipArchive archive = new(memoryStream, ZipArchiveMode.Create, true))
            {
                foreach (LightweightFile file in files)
                {
                    ZipArchiveEntry archiveEntry = archive.CreateEntry($"{pushToFolder}{file.Name}");

                    archiveEntry.LastWriteTime = DateTimeOffset.UtcNow;

                    Stream entryStream = archiveEntry.Open();

                    using BinaryWriter binaryWriter = new(entryStream);

                    binaryWriter.Write(file.File);
                }
            }

            byte[] zip = memoryStream.ToArray();

            return zip;
        }
    }
}