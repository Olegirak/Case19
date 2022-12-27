// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

//14212 -> нет

//12821 -> да

//23432 -> да
int N = int.Parse(Console.ReadLine()!);
int Razryad(int N)
    {
        int k = 1;
        int N1 = N/10;
        while (N1>0)
            {
                N1=N1/10;
                k=k+1;
            }
        return k;    
    }
   
string Palindrom(int N)
{
    string d = "Да";
    int i = 1;
    int k= Razryad( N);
    int j = k;
    int m = (int)(k/2);
    while (i<=m)
    {
        int a =(int)((int)(N%(int)Math.Pow(10,(j)))/(int)(Math.Pow(10,(j-1))));
        int b = (int)((N%(Math.Pow(10,i)))/Math.Pow(10,(i-1)));
        
        if (a ==b )
        {
            i = i+1;
            j = j-1;
           
        }
        else
        {
             d = "Нет";
            return d;
            break;
        }       
    }   
return d ;   
}

Console.WriteLine(Palindrom(N));