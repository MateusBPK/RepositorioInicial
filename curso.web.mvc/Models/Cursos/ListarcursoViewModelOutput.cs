using System.ComponentModel.DataAnnotations;

namespace curso.web.mvc.Models.Cursos
{
    public class ListarcursoViewModelOutput
    {
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "A descrição é obrigatório")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "O login é obrigatório")]
        public string Login { get; set; }

    }
}
