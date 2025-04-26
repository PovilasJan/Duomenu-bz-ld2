namespace Org.Ktu.Isk.P175B602.Autonuoma.Models;

using System.ComponentModel.DataAnnotations;

/// <summary>
/// Model of 'Klientas' entity.
/// </summary>
public class Klientas
{
    [Display(Name = "Vardas")]
    [Required]
    public string Vardas { get; set; }

    [Display(Name = "Pavardė")]
    [Required]
    public string Pavarde { get; set; }

    [Display(Name = "Asmens kodas")]
    [Required]
    public int AsmensKodas { get; set; } // Changed to int to match the database

    [Display(Name = "Telefonas")]
    public string Telefonas { get; set; }

    [Display(Name = "Elektroninis paštas")]
    [EmailAddress]
    public string Epastas { get; set; }

    [Display(Name = "Amžius")]
    public int? Amzius { get; set; } // Nullable to match the database

    [Display(Name = "Registracijos data")]
    public DateTime? RegistracijosData { get; set; } // Nullable to match the database

    [Display(Name = "Lojalumo taškai")]
    public int? LojalumoTaskai { get; set; } // Nullable to match the database

    [Display(Name = "Adresas")]
    public string Adresas { get; set; }
}
