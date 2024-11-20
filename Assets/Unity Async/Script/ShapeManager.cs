using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Study.UnityAsync.Await
{
    public class ShapeManager : MonoBehaviour
    {
        [SerializeField] private Shape[] _shapes;

        [Button]
        public void Begin()
        {
            for (int i = 0; i < _shapes.Length; i++)
            {
                StartCoroutine(_shapes[i].RotateForSecond(1 + 1 * i));
            }
        }
    }

}
