using UnityEngine;

public abstract class SubjectBase : MonoBehaviour
{
    #region Private methods

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (!col.gameObject.CompareTag(Tags.Basket))
            return;
        ApplyEffect(col);
        Destroy(gameObject);
    }

    protected abstract void ApplyEffect(Collision2D col);

    #endregion
}