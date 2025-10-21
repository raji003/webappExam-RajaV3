namespace FirstMVC.Models
{
	public class storyAct
    {
        public int storyActId { get; set; }
		public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        
        
		public string? Description { get; set; }
		public string? ImageUrl { get; set; }

        public int? characterId { get; set; }
        public characters? Character { get; set; }
	}
}