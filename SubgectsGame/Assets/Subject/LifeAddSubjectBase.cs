using UnityEngine;

public class LifeAddSubjectBase : SubjectBase
{
    #region Variables

    [Header(nameof(LifeAddSubjectBase))]
    [SerializeField] private int _life;

    #endregion


    #region Private methods

    protected override void ApplyEffect(Collision2D col)
    {
        Statistics.Instance.IncrementLife(_life);
    }

    #endregion
}