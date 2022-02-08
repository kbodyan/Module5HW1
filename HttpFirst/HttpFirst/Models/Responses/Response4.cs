using HttpFirst.Resources;

namespace HttpFirst.Responses
{
    public class Response4
    {
        public int Page { get; set; }
        public int Per_page { get; set; }
        public int Total { get; set; }
        public int Total_pages { get; set; }
        public List<Data>? Data { get; set; }
        public Support? Support { get; set; }
    }
}
