using System;
using System.Threading;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Study.UnityAsync.UniTaskStudy
{
    public class CancellationTokenTest : MonoBehaviour
    {
        #region Current Workflow

        // private CancellationTokenSource _tokenSource;

        private async void Awake()
        {
            // _tokenSource = new CancellationTokenSource();
            try
            {
                // await LongRunningTask(_tokenSource.Token);
                await LongRunningTask(destroyCancellationToken);
                // await LongRunningTask(Application.exitCancellationToken);
            }
            catch (OperationCanceledException e)
            {
                Debug.Log("Destroy token was cancel! " + e.Message);
            }
        }

        // private void OnDestroy()
        // {
        //     CancelToken();
        // }
        //
        // [Button]
        // void CancelToken()
        // {
        //     _tokenSource.Cancel();
        //     _tokenSource.Dispose();
        // }

        private static async Task LongRunningTask(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                await UniTask.WaitForSeconds(1,true,PlayerLoopTiming.Update, token);
                Debug.Log("This long running task is still running.");
            }
        }

        #endregion
        
    }
}