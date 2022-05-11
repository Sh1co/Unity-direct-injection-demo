using System;

public class BallBallModel : IBallModel
{
    public BallBallModel(int health) => _health = health;

    public void OnCollidedWithBox()
    {
        _health--;
        HealthChanged?.Invoke();
    }

    public int GetHealth()
    {
        return _health;
    }

    public event Action HealthChanged;

    private int _health;
}