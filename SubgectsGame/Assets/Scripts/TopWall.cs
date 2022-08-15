using System.Collections;
using UnityEngine;

public class TopWall : MonoBehaviour
{
    #region Variables

    [Header("Subjects")]
    [Range(0f, 1f)]
    [SerializeField] private float _subjectSpawnChance;
    [SerializeField] private SubjectInfo[] _subjectInfoArray;

    [Header("Random direction characteristics")]
    [Range(-2, 2)]
    [SerializeField] private float _xMin;
    [Range(-2, 2)]
    [SerializeField] private float _xMax;
    [Range(1, 5)]
    [SerializeField] private float _yMin;
    [Range(1, 5)]
    [SerializeField] private float _yMax;

    #endregion


    #region Unity lifecycle

    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            SpawnPickUp();
        }
    }

    private void OnValidate()
    {
        if (_subjectInfoArray == null || _subjectInfoArray.Length == 0)
        {
            return;
        }

        foreach (SubjectInfo subjectInfo in _subjectInfoArray)
        {
            subjectInfo.OnVolidate();
        }
    }

    #endregion


    #region Private methods

    private void SpawnPickUp()
    {
        if (_subjectInfoArray == null || _subjectInfoArray.Length == 0)
        {
            return;
        }

        float random = Random.Range(0, 1f);
        if (random > _subjectSpawnChance)
        {
            return;
        }

        int chanceSum = 0;

        foreach (SubjectInfo subjectInfo in _subjectInfoArray)
        {
            chanceSum += subjectInfo.SpawnChance;
        }

        int randomChance = Random.Range(0, chanceSum);
        int currentChance = 0;
        int currentIndex = 0;


        for (int i = 0; i < _subjectInfoArray.Length; i++)
        {
            SubjectInfo pickUpInfo = _subjectInfoArray[i];
            currentChance += pickUpInfo.SpawnChance;


            if (currentChance >= randomChance)
            {
                currentIndex = i;
                break;
            }
        }

        Vector2 randomDirection = new Vector2(Random.Range(_xMin, _xMax), Random.Range(_yMin, _yMax));

        SubjectBase pickUpPrefab = _subjectInfoArray[currentIndex].Subject;
        Instantiate(pickUpPrefab, randomDirection, Quaternion.identity);
    }

    #endregion
}