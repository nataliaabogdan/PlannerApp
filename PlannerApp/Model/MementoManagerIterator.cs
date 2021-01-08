namespace PlannerApp.Model
{
    public class MementoManagerIterator: Iterator
    {
        private MementoManager _mementoManager;
        private int position = -1;
        public MementoManagerIterator(MementoManager mementoManager)
        {
            _mementoManager = mementoManager;
        }
        public override int Key()
        {
            return position;
        }

        public override object Current()
        {
            return _mementoManager.getMementos()[position];
        }

        public override bool MoveNext()
        {
            int newposition = position + 1;
            if (newposition < _mementoManager.getMementos().Count)
            {
                position = newposition;
                return true;
            }

            return false;
        }

        public override void Reset()
        {
            position = 0;
        }
    }
}