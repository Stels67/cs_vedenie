﻿// напишите подпрограмму нахождения растояниия между двумя точками 

double Distance(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y1-y2,2));
}

double x1=0,y1=0,x2=2,y2=2;

//double Distance=Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y1-y2,2));
double distance=Distance(0,0,2,2);
System.Console.WriteLine(distance);