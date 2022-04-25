using System;
using TMPro;
using UnityEngine;


public class BallView : MonoBehaviour
{
    [SerializeField] private TMP_Text _healthText;

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.transform.TryGetComponent(out BoxTag _)) return;
        CollidedWithBox?.Invoke();
    }


    public void DisplayHealth(int health)
    {
        _healthText.text = health.ToString();
    }

    public event Action CollidedWithBox;
}