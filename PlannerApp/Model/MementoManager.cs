using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using PlannerApp.View;

namespace PlannerApp.Model
{
    public class MementoManager: IteratorAggregate
    {
        private List<IMemento> _mementos = new List<IMemento>();

        private PlannerData _plannerData = null;

        public MementoManager(PlannerData plannerData)
        {
            _plannerData = plannerData;
        }

        public List<IMemento> getMementos()
        {
            return _mementos;
        }
        public void Backup()
        {
            _mementos.Add(_plannerData.Save());
        }

        public void Undo()
        {
            if (_mementos.Count != 0)
            {
                var memento = this._mementos.Last();
                this._mementos.Remove(memento);
                this._plannerData.Restore(memento);
            }
        }

        public override IEnumerator GetEnumerator()
        {
            return new MementoManagerIterator(this);
        }
    }
}