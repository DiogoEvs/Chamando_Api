using Newtonsoft.Json;

namespace VoeAirlines_Blazor.Data;
public class Login
{
    [JsonProperty("Id")]
    public int Id { get; set; }
    [JsonProperty("Usuario")]
    public string? Usuario { get; set; }

    [JsonProperty("Senha")]
    public string? Senha { get; set; }

    [JsonProperty("DataCriacao")]
    public DateTime DataCriacao { get; set; } = DateTime.Now;
}