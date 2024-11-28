using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using UnityEngine;
using Random = UnityEngine.Random;

public class ThreadPractice : MonoBehaviour
{
    [SerializeField] private bool _useMainThread = false;
    private CancellationTokenSource _cancellationTokenSource;
    private System.Random _random = new System.Random();

    private void Awake()
    {
        _cancellationTokenSource = new CancellationTokenSource();
        RunPerformanceTest(_cancellationTokenSource.Token).Forget();

        // var randomNumber = GetRandomNumber();
        // print( await randomNumber);
    }

    private void OnDestroy()
    {
        _cancellationTokenSource.Cancel();
        _cancellationTokenSource.Dispose();
    }

    public void ToggleThread(bool on)
    {
        _useMainThread = on;
    }

    private async UniTask RunPerformanceTest(CancellationToken token)
    {
        while (!token.IsCancellationRequested)
        {
            if (!_useMainThread) await UniTask.SwitchToThreadPool();
            
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();
            long result = CalculateSum(1, 1000000000);
            stopwatch.Stop();
            
            if (!_useMainThread) await UniTask.SwitchToMainThread();

            Debug.Log($"Thread: {(_useMainThread ? "Main Thread" : "Background Thread")}, " +
                      $"Result: {result}, Time: {stopwatch.ElapsedMilliseconds} ms");
            await UniTask.Delay(1000, cancellationToken: token);
        }
    }

    private long CalculateSum(int start, int end)
    {
        long sum = 0;
        for (int i = start; i <= end; i++)
        {
            sum += i;
        }
        return sum;
    }

    private async UniTask<int> GetRandomNumber()
    {
        int randomNumber = Random.Range(1000, 2000);
        await UniTask.Delay(randomNumber);
        return randomNumber;
    }
}
