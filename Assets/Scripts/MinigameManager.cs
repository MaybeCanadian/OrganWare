using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameManager
{
    #region Singleton
    private static MinigameManager Instatnce = null;
    public static MinigameManager GetInstance()
    {
        if(Instatnce == null)
        {
            Instatnce = new MinigameManager();
        }

        return Instatnce;
    }
    private MinigameManager()
    {
        Init();
    }
    #endregion

    #region Init Functions
    private void Init()
    {
        Debug.Log("Minigame Manager Init Complete");
    }
    #endregion
}
