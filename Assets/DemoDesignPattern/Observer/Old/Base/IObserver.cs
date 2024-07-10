namespace Observer.Old
{
    public interface IObserver
    {
        public void Notify(Subject subject, object arg);
    }
}