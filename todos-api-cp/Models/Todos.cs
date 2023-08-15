namespace TodosApiCp.Models

{
	public class Todos	
	{
		public int Id { get; set; }

		public required string Title { get; set; }

        public required string Text { get; set; }

		public required DateTime CreatedAt { get; set; }

    }
}

