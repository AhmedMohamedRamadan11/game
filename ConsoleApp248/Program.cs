using ConsoleApp248;
Console.WriteLine("enter number of customer");
int numbers = int.Parse(Console.ReadLine());
test[] arr = new test[numbers];
for (int i = 0; i < numbers; i++)
{
    arr[i] = new test();
}
Console.WriteLine("enter random digit for customers");
bool b = true;
for (int i = 0; i < numbers; i++)
{
    Console.Write($" random digit for customers {i + 1}: ");
    int x = int.Parse(Console.ReadLine());
    arr[i].Rand_arr = x;
    arr[i].Cust_num = i + 1;
    if ((arr[i].Rand_arr > 0) && (arr[i].Rand_arr < 126)) arr[i].inter = 1;
    else if ((arr[i].Rand_arr > 125) && (arr[i].Rand_arr < 251)) arr[i].inter = 2;
    else if ((arr[i].Rand_arr > 250) && (arr[i].Rand_arr < 376)) arr[i].inter = 3;
    else if ((arr[i].Rand_arr > 375) && (arr[i].Rand_arr < 501)) arr[i].inter = 4;
    else if ((arr[i].Rand_arr > 500) && (arr[i].Rand_arr < 626)) arr[i].inter = 5;
    else if ((arr[i].Rand_arr > 625) && (arr[i].Rand_arr < 751)) arr[i].inter = 6;
    else if ((arr[i].Rand_arr > 750) && (arr[i].Rand_arr < 876)) arr[i].inter = 7;
    else if ((arr[i].Rand_arr > 875) && (arr[i].Rand_arr < 1001)) arr[i].inter = 8;
    else { Console.WriteLine("you choose num from 1 to 1000"); return; }
    arr[i].Arrtime =b==true?arr[i].Arrtime=0: arr[i - 1].Arrtime + arr[i].inter;
    b = false;
}
Console.WriteLine(" Enter random digit for service time for each customer");
bool t = true;
for (int i = 0; i < numbers; i++)
{
    Console.Write($" random digit for service {i + 1}: ");
    int x = int.Parse(Console.ReadLine());
    arr[i].Rand_serv = x;
    if ((arr[i].Rand_serv > 0) && (arr[i].Rand_serv < 11)) arr[i].servicetime = 1;
    else if ((arr[i].Rand_serv > 10) && (arr[i].Rand_serv < 31)) arr[i].servicetime = 2;
    else if ((arr[i].Rand_serv > 30) && (arr[i].Rand_serv < 61)) arr[i].servicetime = 3;
    else if ((arr[i].Rand_serv > 60) && (arr[i].Rand_serv < 86)) arr[i].servicetime = 4;
    else if ((arr[i].Rand_serv > 85) && (arr[i].Rand_serv < 96)) arr[i].servicetime = 5;
    else if ((arr[i].Rand_serv > 95) && (arr[i].Rand_serv < 101)) arr[i].servicetime = 6;
    else { Console.WriteLine("you choose num from 1 to 100"); return; }
    arr[i].service_begin =t==true? arr[i].service_begin = 0 : Math.Max(arr[i].Arrtime, arr[i].service_end);
    t = false;
    arr[i].service_end = arr[i].service_begin + arr[i].servicetime;
    arr[i].time_queue = arr[i].service_begin - arr[i].Arrtime;
    arr[i].idle_time = arr[i].service_end > arr[i].Arrtime ? arr[i].service_end - arr[i].Arrtime : 0;
}
Console.WriteLine("\n   ------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("\n  | Cust.| RD. for | Inter_arrival | Arrival | RD. for | Service | T.Service| T.Service| Waiting | Server | \n");
Console.WriteLine("  |  No. |Arrival.T|     Time      |  Time   |Service.T|  Time   |  Begin   |    End   | in Queue| Idle.T |");
Console.WriteLine("\n   ------------------------------------------------------------------------------------------------------------------\n");
for (int i = 0; i < numbers; i++)
{
    Console.WriteLine($"     {arr[i].Cust_num}     {arr[i].Rand_arr}             {arr[i].inter}          {arr[i].Arrtime}         {arr[i].Rand_serv}           {arr[i].servicetime}        {arr[i].service_begin}          {arr[i].service_end}          {arr[i].time_queue}       {arr[i].idle_time}");
    ;
    if (i != numbers)
    {
        Console.WriteLine("   ------------------------------------------------------------------------------------------------------------------\n");
    }
    else
    {
        Console.WriteLine("   --------------------------------------------------------====----------------------------====------====-----====--\n");
    }
}
