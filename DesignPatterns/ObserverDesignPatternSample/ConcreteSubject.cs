using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPatternSample
{
    public class ConcreteSubject : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        private string _subjectState;

        public string SubjectState
        {
            get { return _subjectState; }
            set 
            {
                _subjectState = value;
                Notify();
            }
        } 
        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_subjectState);
            }
        }
    }
}
