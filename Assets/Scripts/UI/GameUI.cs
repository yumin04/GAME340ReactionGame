using UnityEngine;

public class GameUI : MonoBehaviour
{
    private static GameUI instance;

    public static GameUI GetInstance() => instance;
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
    }

    public void OnESCKeyPressed()
    {
        // menu panel pops up
        // Game "stops"
        Debug.Log("ESC key pressed");
    }

    public void OnCheatKeyPressed()
    {
        // Game "stops"
        // Gives all options on instantiating objects 
        Debug.Log("ctrl + shift + q pressed");
    }
}