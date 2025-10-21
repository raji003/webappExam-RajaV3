using SamiLearnGame.Models;

public class UserProgressDB
{
    public int UserProgressID { get; set; }
    public string UserID { get; set; } = string.Empty;
    public int CurrentStoryActId { get; set; }

    public storyAct? CurrentStoryAct { get; set; } 
    public DateTime LastUpdated { get; set; }
    
}