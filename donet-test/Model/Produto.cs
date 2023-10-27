using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace donet_test.Model
{
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Nome { get; set; } = string.Empty;

        [Column(TypeName = "decimal(6,2)")]
        public decimal Preco { get; set; }

        public virtual Categoria? Categoria { get; set; }
    }
}
