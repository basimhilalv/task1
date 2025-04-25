string? n = Console.ReadLine();
int num = int.Parse(n);
int flag = 0;
if(num == 1 || num == 0)
    Console.WriteLine("Not a prime number");
else if(num == 2)
    Console.WriteLine("Prime Number");
else{

for(int i = 2; i<num;i++)
{
    if(num%i == 0)
    {
        flag = 1;
    }
} 
if(flag == 1) Console.WriteLine("Not a prime number");
else Console.WriteLine("Prime Number");
}
