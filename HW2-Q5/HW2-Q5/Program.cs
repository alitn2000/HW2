Console.Write("Enter price : ");
int price = int.Parse(Console.ReadLine());

int t50 = 0, t10 = 0, t5 = 0, t1 = 0, t20 = 0 ;

t50 = price / 50;
price %= 50;

t20 = price / 20;
price %= 20;

t10 = price / 10;
price %= 10;


t5 = price / 5;
price %= 5;

t1 = price;

Console.WriteLine($"t50 : {t50} \nt20 : {t20}\nt10 : {t10}\nt5 : {t5}\nt1 : {t1}");