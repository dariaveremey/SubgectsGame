using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    #region Viriables

    [Header("Basket")]
    [SerializeField] private Vector3 _minSize;
    [SerializeField] private Vector3 _maxSize;

    #endregion


    #region Unity lifecycle

    private void Update()
    {
        MoveWithMouse();
    }

    #endregion


    #region Private methods

    private void MoveWithMouse()
    {
        Vector3 mousePositionInPixels = Input.mousePosition;
        Vector3 mousePositionInUnits = Camera.main.ScreenToWorldPoint(mousePositionInPixels);

        Vector3 currentPosition = transform.position;
        currentPosition.x = mousePositionInUnits.x;
        transform.position = currentPosition;
    }

    #endregion
}