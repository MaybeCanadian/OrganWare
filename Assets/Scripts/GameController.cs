using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    #region Event Dispatchers
    public delegate void UpdateEvent(float delta);

    public static UpdateEvent UpdateTick;
    public static UpdateEvent FixedUpdateTick;
    public static UpdateEvent LateUpdateTick;
    #endregion

    #region Init Functions
    private void Start()
    {
        MinigameManager.GetInstance();
    }
    #endregion

    #region Update Functions
    private void Update()
    {
        UpdateTick?.Invoke(Time.deltaTime);
    }
    private void FixedUpdate()
    {
        FixedUpdateTick?.Invoke(Time.fixedDeltaTime);
    }
    private void LateUpdate()
    {
        LateUpdateTick?.Invoke(Time.deltaTime);
    }
    #endregion

}
