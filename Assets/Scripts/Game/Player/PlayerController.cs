using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils.InputProvider;

namespace Game.Player
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private GameObject head;

        // TODO: 固定のゲーム設定はScriptableObjectにまとめる
        [SerializeField] private float movingSpeed;
        
        // TODO: ゲーム設定は一つにまとめる
        [SerializeField] private float mouseSensitivity;

        private IInputProvider _inputProvider;

        private void Awake()
        {
            // TODO: initializeメソッドを作成し、そこでinput providerの設定を行うようにする
            _inputProvider = new UnityInputProvider();
        }

        private void Update()
        {
            var movingDirection =  _inputProvider.GetMovingDirection();
            var tf = transform;
            
            tf.position += Time.deltaTime * movingSpeed * (tf.forward * movingDirection.z + tf.right * movingDirection.x);

            var viewpointShift = Time.deltaTime * mouseSensitivity * _inputProvider.GetViewpointShift();

            head.transform.localEulerAngles += new Vector3(viewpointShift.x, 0.0f, 0.0f);
            tf.localEulerAngles += new Vector3(0.0f, viewpointShift.y, 0.0f);
        }
    }
}