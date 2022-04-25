using System;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private int _ballInitialHealth = 10;
    private BallPresenter _ballPresenter;

    
    public void Construct(BallView ballView)
    {
        _ballView = ballView;
    }
    
    private void Start()
    {
        var ballModel = new BallModel(_ballInitialHealth);
        _ballPresenter = new BallPresenter(_ballView, ballModel);
    }

    private void OnDestroy()
    {
        _ballPresenter.Dispose();
    }
    
    private BallView _ballView;
}
