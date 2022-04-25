using System;
using UnityEngine;

public interface IBallView
{
    public event Action CollidedWithBox;
    public void DisplayHealth(int health);
}