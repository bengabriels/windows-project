namespace HoGentApp.models
{
    public class Campus : ArticleTarget
    {
        public int CampusId { get; set; }
        public string Name { get; set; }
        public Adres Adres { get; set; }
    }
}