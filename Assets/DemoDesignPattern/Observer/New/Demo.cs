using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Observer.New
{
    public class Demo : MonoBehaviour
    {
        public string title;
        private void Start()
        {
            // ObserverExtension.RegisterListener(this, EventID.OnBulletHit, OnTitleChange);
        }

        void OnTitleChange()
        {
            Debug.Log("Change Title!");
        }

        private void OnValidate()
        {
            
        }
    }

}