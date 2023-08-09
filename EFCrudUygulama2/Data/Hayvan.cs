using System.ComponentModel.DataAnnotations;

namespace EFCrudUygulama2.Data
{
    public class Hayvan
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Ad { get; set; } = null!;
    }
}
