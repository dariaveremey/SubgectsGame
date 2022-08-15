using UnityEngine;
using UnityEngine.UI;

public class UILevelManager : MonoBehaviour
{
    #region Variables

    [Header("Screens")]
    [SerializeField] private GameObject _gameOverScreen;

    [Header("Buttons")]
    [SerializeField] private Button _restartButton;
    [SerializeField] private Button _exitButton;

    #endregion


    #region Unity lifecycle

    private void Awake()
    {
        _gameOverScreen.SetActive(false);
    }

    private void Start()
    {
        Statistics.Instance.OnLost += GameOver;

        _restartButton.onClick.AddListener(()=>SceneLoader.Instance.LoaderScene(Scenes.StartScene));
        _exitButton.onClick.AddListener(ExitGame.ExitButtonClicked);
    }

    private void OnDestroy()
    {
        Statistics.Instance.OnLost -= GameOver;
    }

    #endregion


    #region Private methods
  
      private void GameOver(bool isGameOver)
      {
          _gameOverScreen.SetActive(isGameOver);
      }
  
 

    #endregion
}