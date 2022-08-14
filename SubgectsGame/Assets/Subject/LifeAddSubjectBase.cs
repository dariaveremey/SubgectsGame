using UnityEngine;

public class LifeAddSubjectBase : SubjectBase
{
    [Header(nameof(LifeAddSubjectBase))]
    [SerializeField] private int _life;
    protected override void ApplyEffect(Collision2D col)
    {
        Statistics.Instance.IncrementLife(_life);
    }
}