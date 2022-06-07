using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProjetoAulaBackEnd.Models

{
    public class Image
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Extension { get; set; }
        public int Length { get; set; }
        public byte[] Picture { get; set; }
        public string ContentType { get; set; }
    }
}
