using System;
using UnityEngine;
namespace Observer.Old
{
    public class Demo : MonoBehaviour
    {
        public string title = "Rock";

        private VideoData m_VideoData = new VideoData();

        private IObserver m_Observer;
        private void Start()
        {
            m_VideoData.SetTitle(title);
            m_Observer = new YoutubeNotifier();
            m_VideoData.AttachObserver(m_Observer);
        }

        private void OnDestroy()
        {
            m_VideoData.DetachObserver(m_Observer);
        }

        private void OnValidate()
        {
            m_VideoData.SetTitle(title);
        }
    }
}