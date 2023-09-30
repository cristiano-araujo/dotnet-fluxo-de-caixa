namespace dotnet_fluxo_de_caixa.Models;

public class Caixa
{
    public int Id { get; set; }
    public string Tipo { get; set; }
    public double Valor { get; set; }
    public Status Status { get; set; }
    
}