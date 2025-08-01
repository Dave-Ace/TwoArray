//Console.WriteLine("Welcome! Hello World");
//Console.WriteLine("Type 'q' to quit");
//Console.WriteLine("Which Service Do you want \n");
//Console.WriteLine("Press 1: Buy");
//Console.WriteLine("Press 2: Sell");
//Console.WriteLine("Press 3: Fetch");
//string answer = Console.ReadLine();
//while (answer != "q")
//{
//    int parameter = Convert.ToInt32(answer);
//    switch (parameter)
//    {
//        case 1:
//            Console.WriteLine("You choose to buy");
//            break;

//        case 2:
//            Console.WriteLine("You choose to Sell");
//            break;

//        case 3:
//            Console.WriteLine("You choose to Fetch");
//            break;

//        default:
//            Console.WriteLine("You've selected an invalid parameter");
//            break;
//    }

//    Console.WriteLine("Type 'q' to quit");
//    Console.WriteLine("Which Service Do you want \n");
//    answer = Console.ReadLine();
//}

List<int> nums = new List<int> { 2, 7, 11, 15 };
int target = 9;

int index = 0;

for(int i = 0; i < nums.Count; i++)
{
    if (nums[index] + nums[i] == target)
    {
        Console.WriteLine($"[{i}, {i+1}]");
        break;
    }

    if (i == nums.Count() -1)
        index++;
        i = 0;
}

Console.WriteLine("Hello World");