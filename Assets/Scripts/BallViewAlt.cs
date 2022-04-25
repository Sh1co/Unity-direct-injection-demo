using System;
using UnityEngine;

public class BallViewAlt : MonoBehaviour, IBallView
{
    public event Action CollidedWithBox;
    public void DisplayHealth(int health)
    {
        throw new NotImplementedException();
    }
}
