using System;
using System.Collections.Specialized;
using UnityEngine;

public class GameMediator : MonoBehaviour
{
    private static GameMediator instance;
    
    
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    
    public static GameMediator GetInstance()
    {
        return instance;
    }

    private void WhenSpacePressed()
    {
        GameEvents.DestroyMonsterAndTarget?.Invoke();
        GameEvents.DestroyMonsterAndTarget = null;
    }
    private void WhenRPressed()
    {
        MovementAssigner.GetInstance().CreateMonster();
    }
    public void Notify(Action action)
    {
        action.Invoke();
    }

    // private void WhenMonsterInitialized()
    // {
    //     
    // }
    // public Action GetWhenMonsterInitialzied()
    // {
    //     return WhenMonsterInitialized;
    // }
    public Action GetWhenSpacePressed()
    {
        return WhenSpacePressed;
    }

    public Action GetWhenRPressed()
    {
        return WhenRPressed;
    }

}
