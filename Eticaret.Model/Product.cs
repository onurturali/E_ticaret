using System.ComponentModel;

namespace Eticaret.Model
{
    public class Product
    {
        public int Id { get; set; }

        [DisplayName("Ürün Adı")]
        public string Name { get; set; } = string.Empty;

        [DisplayName("Fiyat")]
        public double Price { get; set; }
    }
}
