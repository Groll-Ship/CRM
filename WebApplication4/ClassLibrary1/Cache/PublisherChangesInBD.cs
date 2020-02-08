using data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace busines.Cache
{
    public delegate void ObserverChangesInBD(IEntity _entity);
    public class PablisherChangesInBD
    {
        private static PablisherChangesInBD pablisher = null;
        private ObserverChangesInBD observers = null;

        public event ObserverChangesInBD Event
        {
            add { observers += value; }
            remove { observers -= value; }
        }
        private PablisherChangesInBD() { }

        public static PablisherChangesInBD GetPablisher()
        {
            if (pablisher == null)
                pablisher = new PablisherChangesInBD();
            return pablisher;
        }
        public void Notify(IEntity _entity) {

            observers.Invoke(_entity);
        }
    }
}
