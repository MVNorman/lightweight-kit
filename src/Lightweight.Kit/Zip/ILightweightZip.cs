using Lightweight.Kit.Zip.Models;

namespace Lightweight.Kit.Zip;

public interface ILightweightZip
{
    List<LightweightFile> GetBy(byte[] zip, params string[] extensions);
    List<LightweightFile> GetAll(byte[] zip);
}