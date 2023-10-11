using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace CozaStore.Models;

    [Table("Cor")]
    public class Cor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o Nome")]
        [StringLength(60, ErrorMessage = "O Nome deve possuir no máximo 60 caracteres")]
        public string Nome {get; set; }

        [Required(ErrorMessage = "Informe o Código da Cor")]
        [StringLength(7, ErrorMessage = "O Código deve possuir no máximo 7 caracteres")]
        public string CodigoHexa {get; set; }
    }
