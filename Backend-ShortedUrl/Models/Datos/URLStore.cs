using Backend_ShortedUrl.Models.DTO;

namespace Backend_ShortedUrl.Models.Datos
{
    public static class URLStore
    {
        public static List<URLDto> urlList = new List<URLDto>
        {
            new() { Url="URL 1 desde el URLStore", Id=1, Title="1 Store"},
            new() { Url="URL 2 desde el URLStore", Title="2 Store", Id=2}
        };
    }
}
