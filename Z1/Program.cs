// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int num, rem, sum = 0, given;

Console.Write("Введите номер: ");
num = Convert.ToInt32(Console.ReadLine()); 	
for(given = num; num != 0; num = num / 10)
{
    rem = num % 10;
    sum = sum * 10 + rem;
}
if(given == sum)
{
    Console.Write("{0} Палиндром", given);
}
else
{
    Console.Write("{0} Не палиндром", given);
}	 