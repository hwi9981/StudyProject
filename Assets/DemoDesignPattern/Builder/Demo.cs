using System;
using UnityEngine;
namespace Builder
{
    public class Demo : MonoBehaviour
    {
        private void Start()
        {
            //case 1
            UserData userData = new UserData("VN01", "A", 10, new GameData());

            //case 2
            UserData userDataBuilder = new DataBuilder()
                .SetUserID("VN02")
                .SetUserName("B")
                .SetAge(10)
                .SetGameData(new GameData())
                .Build();
        }
    }
}