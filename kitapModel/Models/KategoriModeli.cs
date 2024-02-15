namespace kitapModel.Models
{
    public class KategoriModeli
    {
        public int KategoriId { get; set; }
        public string KategoriAdi { get; set; }
       List<KitapEvi> kitaplistesi = new List<KitapEvi>();
    }
}
