using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Study.UnityAsync.Await
{
    public class ShapeManager : MonoBehaviour
    {
        [SerializeField] private Shape[] _shapes;
        [SerializeField] private GameObject _finishText;

        [Button]
        public async void Begin()
        {
            _finishText.SetActive(false);
            
            await _shapes[0].RotateForSecond(1);
            var tasks = new List<Task>();
            for (int i = 1; i < _shapes.Length; i++)
            {
                tasks.Add(_shapes[i].RotateForSecond(1 + 1 * i));
            }
            await Task.WhenAll(tasks);
            _finishText.SetActive(true);

            // var randomNumber = GetRandomNumber();
            // print(await randomNumber);
        }

        async Task<int> GetRandomNumber()
        {
            int randomNumber = Random.Range(1000, 3000);
            await Task.Delay(randomNumber);
            return randomNumber;
        }
    }

}
