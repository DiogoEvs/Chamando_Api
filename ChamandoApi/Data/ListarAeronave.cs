using Newtonsoft.Json;

	public class ListarAeronave
	{
		[JsonProperty("Id")]
		public int Id { get; set; }

		[JsonProperty("Modelo")]
		public string? Modelo { get; set; }

		[JsonProperty("Codigo")]
		public string? Codigo { get; set;}
	}

