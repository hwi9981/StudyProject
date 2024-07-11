using UnityEngine;

namespace State
{
    public class StateManager
    {
        private IState m_CurrentState;
        public void ChangeState(IState state)
        {
            if (state == null) return;
            if (m_CurrentState != null && state.GetType() == m_CurrentState.GetType()) return;
            if (m_CurrentState != null)
                m_CurrentState.Exit();
            m_CurrentState = state;
            m_CurrentState.Enter();
        }

        public void ExcuteState()
        {
            if (m_CurrentState != null)
                m_CurrentState.Excute();
        }

        public bool HasSameState<T>(object obj1, object obj2) where T : IState
        {
            if (obj1 is T && obj2 is T)
            {
                return true;
            }

            return false;
        }
    }
}