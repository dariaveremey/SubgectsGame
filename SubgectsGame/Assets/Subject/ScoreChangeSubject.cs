using UnityEngine;
public class ScoreChangeSubject : SubjectBase
{
    #region Variables

    [Header(nameof(ScoreChangeSubject))]
    [SerializeField] private int _score;

    #endregion


    #region Private methods

    protected override void ApplyEffect(Collision2D col)
    {
        Statistics.Instance.IncrementScore(_score);
    }

    #endregion
}

