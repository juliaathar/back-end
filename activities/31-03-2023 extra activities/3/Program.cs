// Escreva um programa que pergunte o raio de uma circunferência, e sem seguida mostre o diâmetro, comprimento e área da circunferência.
Console.Write($"Qual o raio da circunferência?");
float raio = float.Parse (Console.ReadLine());

float diametro = (raio * 2);
float comprimento = (2 * (float) Math.PI * raio);
float area = ( (float) (Math.PI * ((float)Math.Pow(raio, 2))));

Console.WriteLine($"O diâmetro é {diametro}, comprimento é {comprimento} e área da circunferência é {area}");
