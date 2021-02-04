using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Utils.InputProvider
{
    public class UnityInputProvider : IInputProvider
    {
        public Vector3 GetMovingDirection() => new Vector3(Input.GetAxisRaw("Horizontal"), 0.0f, Input.GetAxisRaw("Vertical")).normalized;

        public Vector2 GetViewpointShift() => new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

        public bool GetRunning() => Input.GetKeyDown(KeyCode.LeftShift);

        public bool GetActionKey() => Input.GetKeyDown(KeyCode.E);

        public bool GetUseItemKey() => Input.GetKeyDown(KeyCode.Q);

        public bool GetThrowItemKey() => Input.GetKeyDown(KeyCode.T);

        public bool GetLightSwitchKey() => Input.GetKeyDown(KeyCode.L);
    }
}