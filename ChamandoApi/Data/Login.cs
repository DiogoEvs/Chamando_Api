using Newtonsoft.Json;

namespace ChamandoApi.Data
{
	public class Login
	{
		[JsonProperty("Usuario")]
		public string? Usuario { get; set; }

		[JsonProperty("DataCriacao")]
		public string? DataCriacao { get; set; }
	}
}
