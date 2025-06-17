namespace UFCScoring.Models;

public class Score
{
   public string FightId { get; set; } = String.Empty;
   public int Round { get; set; }
   public int Fighter1Score { get; set; }
   public int Fighter2Score { get; set; }
}