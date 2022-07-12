double valortotal = 0;
double[] percentual=new double[5];
double[] valorparcial=new double[5] { 67836.43, 36678.66, 29229.88, 27165.48, 19849.53 };
string[] cidade=new string[5] {"SP","RJ","MG","ES","Outros"};

valortotal = 67836.43+ 36678.66+29229.88+27165.48+19849.53;

for(int i = 0; i < 5; i++)
{
    percentual[i] = (valorparcial[i] * 100) / valortotal;
    Console.Write(cidade[i]);
    Console.Write(" = ");
    Console.Write(percentual[i].ToString(".0000"));
    Console.WriteLine("%");
}