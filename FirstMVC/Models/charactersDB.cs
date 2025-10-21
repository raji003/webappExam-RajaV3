namespace characters.Models
{
	public class characters
    {
        public int carachterID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
		public string Role { get; set; } = string.Empty;
		public string? Dialog { get; set; }
		public string? ImageUrl { get; set; }
        public string? Translate { get; set; }

        public List<storyAct>? storyActs { get; set; }

	}
}