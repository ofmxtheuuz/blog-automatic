namespace BlogOnline.Models;

public class Artigo
{
    public int ArtigoId { get; set; }
    public string Titulo { get; set; }
    public string Content { get; set; }
    public string Autor { get; set; }
    public DateTime DataEnvio { get; set; }
}