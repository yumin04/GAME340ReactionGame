using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    private static SceneHandler instance;
    
    public static SceneHandler GetInstance() => instance;    

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void OnGameStart()
    {
        if (instance == null)
        {
            GameObject handler = new GameObject("SceneHandler");
            handler.AddComponent<SceneHandler>();
            DontDestroyOnLoad(handler);
        }
    }

    public void Awake()
    {
        instance = this;
    }
    
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    
    public void ReloadScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }
    
    public void QuitGame()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene("PlayScene");
    }
}