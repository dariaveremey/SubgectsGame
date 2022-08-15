using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : SingletonMonoBehavior<SceneLoader>
{
    #region Viriables
    
    [SerializeField] private AudioClip _audioNewLevelLoad;
    
    #endregion

    #region Public methods

    public void LoaderScene(string scene)
    {
        SceneManager.LoadScene(scene);
        AudioPlayer.Instance.PlaySound(_audioNewLevelLoad);
    }

    #endregion
}