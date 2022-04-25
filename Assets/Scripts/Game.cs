using System;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private int _ballInitialHealth = 10;
    private BallPresenter _ballPresenter;

    
    public void Construct(IBallView ballView)
    {
        _ballView = ballView;
    }
    
    private void Start()
    {
        var ballModel = new BallBallModel(_ballInitialHealth);
        _ballPresenter = new BallPresenter(_ballView, ballModel);
    }

    private void OnDestroy()
    {
        _ballPresenter.Dispose();
    }
    
    private IBallView _ballView;
}
