namespace FromArrayToFlexibleList
{
    internal class FlexibleNumberList
    {
        private int[] _numbers;
        private int _count;

        public FlexibleNumberList()
        {
            _numbers = new int[4];
        }

        public void Add(int number)
        {
            var index = _count;
            if (index >= _numbers.Length)
            {
                var newNumbers = new int[_numbers.Length * 2];
                Array.Copy(_numbers, newNumbers, _numbers.Length);
                _numbers = newNumbers;
            }
            _numbers[index] = number;
            _count++;
        }

        public string GetValues()
        {
            return $"Count={_count} Numbers={string.Join(',', _numbers)}";
        }
    }
}
