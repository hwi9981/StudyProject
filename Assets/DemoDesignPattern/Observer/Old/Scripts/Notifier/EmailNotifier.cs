using UnityEngine;
using System;
namespace Observer.Old
{
    public class EmailNotifier : IObserver
    {
        public void Notify(Subject subject, object arg)
        {
            if(subject is VideoData videoData)
            {
                Debug.Log($"Notify all subscribers via EMAIL with new data Name: {videoData.GetTitle()} Description: {videoData.GetDescription()} File name: {videoData.GetFileName()}");
            }
        }
    }
}