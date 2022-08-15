using System;
using UnityEngine;

public class Statistics : SingletonMonoBehavior<Statistics>
{
    #region Events

    public event Action<int> OnScoreChanged;
    public event Action<int> OnLifeLeft;
    public event Action<bool> OnLost;

    public static bool IsGameOver;

    #endregion


    #region Properties

    public int ScoreNumber { get; private set; }
    public int LifeNumber { get; private set; } = 4;

    #endregion


    #region Public methods

    public void IncrementScore(int score)
    {
        ScoreNumber += score;
        OnScoreChanged?.Invoke(ScoreNumber);
    }

    public void IncrementLife(int number)
    {
        LifeNumber += number;
        if (LifeNumber >= 5)
            LifeNumber = 5;
        OnLifeLeft?.Invoke(LifeNumber);
        if (LifeNumber == 0)
        {
            OnLost?.Invoke(true);
            IsGameOver = false;
        }
    }

    #endregion
}