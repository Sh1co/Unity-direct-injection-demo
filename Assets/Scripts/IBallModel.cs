using System;

public interface IBallModel
{
    public void OnCollidedWithBox();
    public int GetHealth();
    
    public event Action HealthChanged;
}