namespace LuxuryProperties.API.DTOs
{
    public class PropertyImageDTO
    {
        public int IdPropertyImage { get; set; }
        public string? File { get; set; }
        public IFormFile Imagen { get; set; }
        public bool Enabled { get; set; }
        public int IdProperty { get; set; }
    }
}
