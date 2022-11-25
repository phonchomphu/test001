class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Size of fruit is L,M,S");
        Console.WriteLine("----------------------");
        
        Queue<char>FruiList = new Queue<char>();
        while(true)
        {
            char fruit_Check;
            fruit_Check = char.Parse(Console.ReadLine());
            {
                if (fruit_Check == 'L')
                {
                    FruiList.Push('1');
                }
                else if(fruit_Check == 'M')
                {
                    FruiList.Push('2');
                }
                else if(fruit_Check == 'S')
                {
                    FruiList.Push('3');
                }
                else if(fruit_Check !='L'&&fruit_Check !='M'&&fruit_Check !='S')
                {
                    break;
                }
            }
        }
        for(int i = 0;i<FruiList.GetLength();i++)
        {
            if (FruiList.Get(i) == '1')
            {
                FruiList.Push('2');
                FruiList.Push('2');
            }
            else if (FruiList.Get(i) == '2')
            {
                FruiList.Push('3');
                FruiList.Push('3');
                FruiList.Push('3');
            }
        }
        Console.WriteLine("-----------------------------------");
        for (int i = 0 ;i<FruiList.GetLength();i++)
        {
            Console.Write(FruiList.Get(i));
        }
    }
}