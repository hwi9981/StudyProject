using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
namespace Study.UnityAsync.Await
{
    public class Shape : MonoBehaviour
    {
        // public IEnumerator RotateForSecond(float duration)
        // {
        //     var end = Time.time + duration;
        //     while (Time.time < end)
        //     {
        //         transform.Rotate(new Vector3(1, 1) * Time.deltaTime * 150);
        //         yield return null;
        //     }
        // }
        public async Task RotateForSecond(float duration)
        {
            var end = Time.time + duration;
            while (Time.time < end)
            {
                transform.Rotate(new Vector3(1, 1) * Time.deltaTime * 150);
                await Task.Yield();
            }
        }
    }

}