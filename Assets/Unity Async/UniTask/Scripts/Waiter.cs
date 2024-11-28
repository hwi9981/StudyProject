using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using TMPro;
using Cysharp.Threading.Tasks;
namespace Study.UnityAsync.UniTaskStudy
{
    public class Waiter : MonoBehaviour
    {
        [SerializeField] private TMP_Text _btnText;
        [SerializeField] private bool _stopLoop = false;
        
        private int _taskCounter = 0;
        private int _awaitableCounter = 0;
        private const int MAX_COUNT = 20;
        
        private bool _isTimeStopping = false;
        
        private void Start()
        {
            // TaskLoop();
            // AwaitableLoop();
            StartCoroutine(CoroLoop());
        }

        private async void TaskLoop()
        {
            while (!_stopLoop && _taskCounter < MAX_COUNT)
            {
                await Task.Delay(1000);
                _taskCounter++;
                Debug.Log("Task: " + _taskCounter);
            }
        }

        private async void AwaitableLoop()
        {
            while (!_stopLoop && _awaitableCounter < MAX_COUNT)
            {
                // await Awaitable
                // UnityEngine.a
                //await UniTask
                await UniTask.Delay(1000);
                _awaitableCounter++;
                Debug.Log("UniTask: " + _awaitableCounter);
            }
        }
        IEnumerator CoroLoop()
        {
            var coroCounter = 0;
            WaitForSeconds wait = new WaitForSeconds(1);
            while (!_stopLoop && coroCounter < MAX_COUNT)
            {
                yield return wait;
                coroCounter++;
                Debug.Log("Corotinue: " + coroCounter);
            }
        }
        public void ToggleTime()
        {
            _isTimeStopping = !_isTimeStopping;
            Time.timeScale = _isTimeStopping ? 0 : 1;
            _btnText.text = _isTimeStopping ? "Continue" : "Stop";
        }
    }
}
