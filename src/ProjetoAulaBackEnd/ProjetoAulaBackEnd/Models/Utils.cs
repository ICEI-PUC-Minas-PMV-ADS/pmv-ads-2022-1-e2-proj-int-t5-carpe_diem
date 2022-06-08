using Microsoft.AspNetCore.Http;
using System.IO;

namespace ProjetoAulaBackEnd.Models
{
    public static class Utils
{
    public static string GetExtension(this IFormFile file)
    {
        return Path.GetExtension(file.FileName);
    }
    public static byte[] ToByteArray(this IFormFile file)
    {
            using BinaryReader reader = new BinaryReader(file.OpenReadStream());
            return reader.ReadBytes((int)file.Length);
        }
}
}
