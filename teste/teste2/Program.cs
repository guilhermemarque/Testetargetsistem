//calcula a sequencia de fibonacci com base no numero dado
int seqf(int n)
{
	if (n == 0) return 0;
	if (n == 1 || n == 2) return 1;
	else return seqf(n - 1) + seqf(n - 2);
}

//coloca a sequencia original de fibonacci no vetor
int[] m=new int[20];
int j = 0;
for (int i = 0; i < 20; i++)
{
	m[i]=seqf(j);
	j++;
}

int x = 4;
int y = x;
Console.WriteLine("Sequencia de Fibonacci: ");
for (int i = 0; i < 20; i++)
{
	Console.Write(seqf(x));
    if (i == 19)
		Console.WriteLine();
	else
		Console.Write(",");
	x++;
}

//compara para ver se o numero esta na sequencia
for(int n = 0; n < 20; n++)
{
	if (y == m[n])
	{ 
		Console.WriteLine("Pertence a sequencia");
		return 1;
	}
}
Console.WriteLine("Não pertence a sequencia");
return 1;
