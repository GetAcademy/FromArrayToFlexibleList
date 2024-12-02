namespace FromArrayToFlexibleList
{
    internal class FlexibleList<T>
    {
        private T[] _values;
        private int _count;

        public FlexibleList()
        {
            _values = new T[4];
        }

        public void Add(T value)
        {
            var index = _count;
            if (index >= _values.Length)
            {
                var newValues = new T[_values.Length * 2];
                Array.Copy(_values, newValues, _values.Length);
                _values = newValues;
            }
            _values[index] = value;
            _count++;
        }

        public string GetValues()
        {
            return $"Count={_count} Numbers={string.Join(',', _values)}";
        }
    }
}
