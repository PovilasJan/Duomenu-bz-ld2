namespace Org.Ktu.Isk.P175B602.Autonuoma.Models;

using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

/// <summary>
/// Model of 'Darbuotojas' entity.
/// </summary>
public class Darbuotojas
{
    [Display(Name = "Vardas")]
    [MaxLength(20)]
    [Required]
    public string Vardas { get; set; }

    [Display(Name = "Pavardė")]
    [MaxLength(20)]
    [Required]
    public string Pavarde { get; set; }

    [Display(Name = "Asmens Kodas")]
    [Required]
    public int AsmensKodas { get; set; }

    [Display(Name = "Elektroninis Paštas")]
    [EmailAddress]
    public string ElPastas { get; set; }

    [Display(Name = "Telefono Numeris")]
    [Phone]
    public string TelNr { get; set; }

    [Display(Name = "Pozicija")]
    [MaxLength(21)]
    public string Pozicija { get; set; }

    [Display(Name = "Elektroninės Parduotuvės ID")]
    [Required]
    public int FkElektronineParduotuveId { get; set; }
}
