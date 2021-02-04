using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Utils.InputProvider
{
    public interface IInputProvider
    {
        Vector3 GetMovingDirection();

        Vector2 GetViewpointShift();

        bool GetRunning();

        bool GetActionKey();

        bool GetUseItemKey();

        bool GetThrowItemKey();

        bool GetLightSwitchKey();
    }
}