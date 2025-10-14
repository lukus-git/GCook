using System.ComponentModel.DataAnnotations;

namespace GCook.ViewModels;

public class LoginVM
{
    [Display(Name = "email ou nome de usuario", Prompt = "informe seu email ou nome de usuario")]
    [Required(ErrorMessage ="o Email ou Nome de usuario é obrigatorio")]
    public string Email { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Senha de Acesso", Prompt = "*********")]
    [Required(ErrorMessage ="A senha é obrigatoria")]
    public string Senha {get; set;}

    [Display(Name = "Manter Conectado?")]
    public bool Lembrar { get; set; } = false;

    public string UrlRetorno { get; set; }
}
