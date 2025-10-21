using System.ComponentModel.DataAnnotations;

namespace FirstMVC.Models
{
	public class Characters
    {
        [Key]    
    public int CharacterID { get; set; } 

    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string Role { get; set; } = string.Empty;
    public string? Dialog { get; set; }
    public string? ImageUrl { get; set; }
    public string? Translate { get; set; }

    public List<StoryAct>? StoryActs { get; set; }
}

}