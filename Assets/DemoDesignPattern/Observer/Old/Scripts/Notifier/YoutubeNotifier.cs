using UnityEngine;

namespace Observer.Old
{
    public class YoutubeNotifier : IObserver
    {
        public void Notify(Subject subject, object arg)
        {
            if(subject is VideoData videoData)
            {
                Debug.Log($"Notify all subscribers via YOUTUBE with new data Name: {videoData.GetTitle()} Description: {videoData.GetDescription()} File name: {videoData.GetFileName()}");
            }
        }
    }
}