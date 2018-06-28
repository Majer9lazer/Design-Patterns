using System;
using System.Collections.Generic;

namespace DesignPattern.Lesson6.Observable
{
    class YouTubeChannel : IObservable

    {
        private readonly string _name;
        private readonly List<string> _messages = new List<string>();
        private readonly List<IObserver> _subscribes = new List<IObserver>();

        public YouTubeChannel(string name)
        {
            this._name = name;
        }
        public void AddVideo(string videoName)
        {
            _messages.Add(videoName);
            NotifyObservers();
        }
        public void AddObserver(IObserver observer)
        {
            _subscribes.Add(observer);
            Console.WriteLine(observer.UserSubscribe());
        }

        public void RemoveObserver(IObserver observer)
        {
            _subscribes.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in _subscribes)
            {
                observer.Subscribe(_messages[_messages.Count - 1], _name);
            }
        }

        public string GetName()
        {
            return _name;
        }
    }
}
