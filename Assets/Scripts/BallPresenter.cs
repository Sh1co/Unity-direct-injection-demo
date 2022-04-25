
using System;

public class BallPresenter :IDisposable
{
    private readonly IBallModel _ballBallModel;
    private readonly IBallView _ballView;

    public BallPresenter(IBallView ballView, IBallModel ballBallModel)
    {
        _ballBallModel = ballBallModel;
        _ballView = ballView;
        _ballBallModel.HealthChanged += OnHealthChanged;
        _ballView.CollidedWithBox += OnCollidedWithBox;
        
        OnHealthChanged();
    }
    
    public void Dispose()
    {
        _ballBallModel.HealthChanged -= OnHealthChanged;
        _ballView.CollidedWithBox -= OnCollidedWithBox;
    }

    private void OnCollidedWithBox()
    {
        _ballBallModel.OnCollidedWithBox();
    }

    private void OnHealthChanged()
    {
        _ballView.DisplayHealth(_ballBallModel.GetHealth());
    }
}
