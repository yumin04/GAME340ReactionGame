using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
public class MainUI : MonoBehaviour
{
    [SerializeField] private GameObject _coverPanel;
    
    public void OnStartButtonClick()
    {
        SceneHandler.GetInstance().LoadGameScene();
    }

    public void OnQuitButtonClick()
    {
        _coverPanel.SetActive(true);
    }

    public void OnYesButtonClick()
    {
        SceneHandler.GetInstance().QuitGame();
    }

    public void OnNoButtonClick()
    {
        _coverPanel.SetActive(false);
    }
}
