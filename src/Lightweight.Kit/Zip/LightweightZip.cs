using System.IO;
using System.IO.Compression;
using Lightweight.Kit.Extensions;
using Lightweight.Kit.Zip.Models;

namespace Lightweight.Kit.Zip;

public class LightweightZip : ILightweightZip
{
    public List<LightweightFile> GetBy(byte[] zip, params string[] extensions)
    {
        List<LightweightFile> files = new();

        using MemoryStream memoryStream = new(zip);

        using ZipArchive zipArchive = new(memoryStream, ZipArchiveMode.Read);

        IEnumerable<ZipArchiveEntry> entries = zipArchive.Entries.Where(i => extensions.Contains(Path.GetExtension(i.Name)));

        foreach (ZipArchiveEntry entry in entries)
        {
            using Stream entryStream = entry.Open();

            files.Add(new LightweightFile
            {
                File = entryStream.ToByteArray(),
                Name = entry.Name
            });
        }

        return files;
    }

    public List<LightweightFile> GetAll(byte[] zip)
    {
        List<LightweightFile> files = new();

        using MemoryStream memoryStream = new(zip);

        using ZipArchive zipArchive = new(memoryStream);

        foreach (ZipArchiveEntry entry in zipArchive.Entries)
        {
            using Stream entryStream = entry.Open();

            files.Add(new LightweightFile
            {
                File = entryStream.ToByteArray(),
                Name = entry.Name
            });
        }

        return files;
    }
}