

using FromArrayToFlexibleList;

var list = new List<string>();
while (true)
{
    var text = Console.ReadLine();
    list.Add(text);
    Console.WriteLine(string.Join(',', list));
}


//var list = new FlexibleList<string>();
//while (true)
//{
//    var text = Console.ReadLine();
//    list.Add(text);
//    Console.WriteLine(list.GetValues());
//}


//var list = new FlexibleNumberList();
//while (true)
//{
//    var numberStr = Console.ReadLine();
//    var number = Convert.ToInt32(numberStr);
//    list.Add(number);
//    Console.WriteLine(list.GetValues());
//}



//var numbers = new int[4];
//var count = 0;
//while (true)
//{
//    var numberStr = Console.ReadLine();
//    var number = Convert.ToInt32(numberStr);
//    var index = count;
//    if (index >= numbers.Length)
//    {
//        var newNumbers = new int[numbers.Length * 2];
//        Array.Copy(numbers, newNumbers, numbers.Length);
//        numbers = newNumbers;
//    }
//    numbers[index] = number;
//    count++;

//    Console.WriteLine($"Count={count} Numbers={string.Join(',', numbers)}");
//}

