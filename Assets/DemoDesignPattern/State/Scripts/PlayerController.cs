using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace State
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float speed = 1; 
        private StateManager m_StateManager = new StateManager();
        public IdleState idleState { get; private set; }
        public WalkState walkState { get; private set; }
        private void Start()
        {
            idleState = new IdleState(this);
            walkState = new WalkState(this);
            m_StateManager.ChangeState(idleState);
        }
        private void Update()
        {
            m_StateManager.ExcuteState();

            if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
            {
                m_StateManager.ChangeState(walkState);
            }
            else
            {
                m_StateManager.ChangeState(idleState);
            }
        }

        public void Move(Vector3 movement)
        {
            transform.Translate(movement * speed);
        }
    }
}