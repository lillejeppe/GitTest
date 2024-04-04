//SUP FUCKERS!
int[] monthlyPay = { 10000, 20000, 15000, 20000, 30000, 15000 };
double sum = 0;
for (int i = 0; i < monthlyPay.Length; i++)
{
    sum += monthlyPay[i];
    Console.WriteLine(monthlyPay[i]);
}

double average = sum / monthlyPay.Length;
Console.WriteLine("Gennemsnit: " + average.ToString("N2"));
