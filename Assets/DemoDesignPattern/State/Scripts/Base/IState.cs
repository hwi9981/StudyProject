using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace State
{
    public interface IState
    {
        public void Enter();
        public void Excute();
        public void Exit();
    }
}