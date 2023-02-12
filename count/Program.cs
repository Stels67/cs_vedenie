 // подсчитать колличество цифр и сумму цифр

 int N=1234;
 N=Convert.ToInt32(Console.ReadLine());
 int counter=0; 
 int sum=0;

 while(N!=0)
 {
    //counter=counter+1;
    counter++;
    int d=N%10;
    //sum=sum+d;
    sum+=d;
    //N=N/10;
    N/=10;
 }
System.Console.WriteLine(counter);
System.Console.WriteLine(sum);
