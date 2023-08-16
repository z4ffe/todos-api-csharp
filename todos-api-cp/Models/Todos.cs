namespace todos_api_cp.Models

{
	public class Todos	
	{
		public int Id { get; set; }

		public required string Title { get; set; }

        public required string Text { get; set; }

		public required bool Completed { get; set; }

        public required bool Flag { get; set; }

        public required DateTime CreatedAt { get; set; }

		public int UserId { get; set; }

		public Users User { get; set; }
    }
}

