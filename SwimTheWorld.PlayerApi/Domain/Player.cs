namespace SwimTheWorld.PlayerApi.Domain;

public class Player
{
    public string UserName { get; set; }
    public int Id { get; set; }
    public string Email { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public double DistanceInKilometers { get; set; }
}
