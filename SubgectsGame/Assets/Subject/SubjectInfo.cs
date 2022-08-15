using System;
using UnityEngine;

[Serializable]
public class SubjectInfo
{
    #region Variables

    [HideInInspector]
    public string name;
    public SubjectBase Subject;
    public int SpawnChance;

    #endregion


    #region Private methods

    public void OnVolidate()
    {
        name = Subject == null ? String.Empty : Subject.name;
    }

    #endregion
}