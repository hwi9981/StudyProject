using UnityEngine;

namespace State
{
    public class IdleState : IState
    {
        private PlayerController m_Controller;
        public IdleState(PlayerController controller)
        {
            m_Controller = controller;
        }
        public void Enter()
        {
            Debug.Log("Enter Idle state");
        }

        public void Excute()
        {
            Debug.Log("Excute Idle state");
        }

        public void Exit()
        {
            Debug.Log("Exit Idle state");
        }
    }

    public class WalkState : IState
    {
        //TO DO Use inherit here
        private PlayerController m_Controller;
        public WalkState(PlayerController controller)
        {
            m_Controller = controller;
        }
        public void Enter()
        {
            Debug.Log("Enter Walk state");
        }

        public void Excute()
        {
            Debug.Log("Excute Walk state");
            var movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            m_Controller.Move(movement);
        }

        public void Exit()
        {
            Debug.Log("Exit Walk state");
        }
    }
    
}