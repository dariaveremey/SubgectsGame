using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    [Header("Buttons")]
    [SerializeField] private Button _startButton;
    

    private void Start()
    {
        _startButton.onClick.AddListener(()=>SceneLoader.Instance.LoaderScene(Scenes.Level1));
    }
}