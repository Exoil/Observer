using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class News : ObserverAble
    {
        public List<Observer> observerList;
        private string news;
        public News()
        {
            observerList = new List<Observer>();
        }

        public void Attach(Observer observer)
        {

            observerList.Add(observer);
        }

        public void Detach(Observer observer)
        {
            observerList.Remove(observer);
        }

        public void Notify()
        {
            foreach(var result in observerList)
            {
                result.Update();
            }
        }

        public void UpdateNews(string newArticle)
        {
            news = newArticle;
            Notify();
        }

        public string GetNews()
        {
            return this.news;
        }
    }
}
