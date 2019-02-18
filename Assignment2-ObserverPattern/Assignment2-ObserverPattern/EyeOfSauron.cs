using System;
using System.Collections.Generic;

namespace Assignment2_ObserverPattern
{
    public class EyeofSauron : IObservable<EyeofSauron>
    {
        public List<IObserver<BadGuy>> Observers { get; set; }
        public int KnownHobbits { get; set; }
        public int KnownElves { get; set; }
        public int KnownDwarves { get; set; }
        public int KnownMen { get; set; }

        public EyeofSauron()
        { }

        public void NotifyObservers()
        {
            foreach (var item in Observers)
            {
                item.OnNext(new BadGuy());
            }
        }

        public void SetEnemies(int hobbits, int elves, int dwarves, int men)
        {
            this.KnownHobbits = hobbits;
            this.KnownElves = elves;
            this.KnownDwarves = dwarves;
            this.KnownMen = men;
        }

        public IDisposable Subscribe(IObserver<BadGuy> observer)
        {
            throw new NotImplementedException();
        }

        public void UnRegister(IObserver<BadGuy> badGuy)
        {
            Observers.RemoveAt(Observers.IndexOf(badGuy));
        }

        public IDisposable Subscribe(IObserver<EyeofSauron> observer)
        {
            throw new NotImplementedException();
        }
    }
}