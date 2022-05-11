using System;
using TMPro;
using UnityEngine;


public class BallView : MonoBehaviour, IBallView
{

    public event Action CollidedWithBox;
    
    public void Construct(TMP_Text healthText)
    {
        _healthText = healthText;
    }

    
    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.transform.TryGetComponent(out BoxTag _)) return;
        CollidedWithBox?.Invoke();
    }


    public void DisplayHealth(int health)
    {
        _healthText.text = health.ToString();
    }

    
    private TMP_Text _healthText;
}