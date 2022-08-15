using UnityEngine;

public class LostZone : MonoBehaviour
{
    
    #region Unity lifycycle

    private void OnCollisionEnter2D(Collision2D col)

    {
        if (col.gameObject.CompareTag(Tags.NegativeEffects))
        {
            Statistics.Instance.IncrementLife(-1);
        }

        Destroy(col.gameObject);
    }

    #endregion
}