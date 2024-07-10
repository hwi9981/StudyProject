using System.Collections.Generic;

namespace Observer.Old
{
    public class Subject
    {
        private List<IObserver> m_Observers = new List<IObserver>();

        public void AttachObserver(IObserver observer)
        {
            m_Observers.Add(observer);
        }

        public void DetachObserver(IObserver observer)
        {
            m_Observers.Remove(observer);
        }

        public void NotifyObservers(Subject subject, object arg)
        {
            m_Observers.ForEach((observer) => observer.Notify(subject, arg));
        }
    }
}