using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2_ObserverPattern
{
    public class BadGuy : IObserver<string>
    {
        public IObservable<EyeofSauron> LeaderBeingObserved { get; set; }
        public String BadGuyName { get; set; }
        public string Enemies { get; set; }

        public BadGuy()
        {

        }

        public BadGuy(IObservable<EyeofSauron> leaderToObserve, String nameofBadGuy)
        {
            this.LeaderBeingObserved = leaderToObserve;
            this.BadGuyName = nameofBadGuy;
        }

        public String DisplayKnownEnemies()
        {
            return Enemies;
        }

        public void Defeated()
        {
            LeaderBeingObserved = null;
        }


        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(String enemies)
        {
            Enemies = enemies;
        }
    }
}
