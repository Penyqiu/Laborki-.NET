int[] array= {1,2,1,12,4,5,1,2,2137,123,321};

void findMax()
{
    Console.WriteLine("MAX: "+array.Max());
}

void findMin()
{
    Console.WriteLine("MIN: "+array.Min());
}

Thread t1 = new Thread(new ThreadStart(findMax));
Thread t2 = new Thread(new ThreadStart(findMin));
t1.Start();
t2.Start();