using System.Xml;
XmlReader reader = XmlReader.Create(@"Z:\Meus Documentos\Downloads\dados (2).xml");
double media = 0;
double v=0,mmenor = 0,mmaior=0;
int i=1,count=0;
string aux,n;
while (reader.Read())
{
        switch (reader.Name.ToString())
        {
            case "valor":
                aux = reader.ReadString();
                media = media + double.Parse(aux);
                    if (i == 1)
                    {
                            mmenor = double.Parse(aux);
                            mmaior = double.Parse(aux);
                            i++;
                    }
            break;
        }
}
v=mediafunc(media);
XmlReader leitor = XmlReader.Create(@"Z:\Meus Documentos\Downloads\dados (2).xml");
while (leitor.Read())
{
    switch (leitor.Name.ToString())
    {
        case "valor":
            aux = leitor.ReadString();
            if (mmenor > double.Parse(aux) && double.Parse(aux) != 0)
                mmenor = double.Parse(aux);
            if (mmaior < double.Parse(aux))
                mmaior = double.Parse(aux);
            if (v < double.Parse(aux))
                count++;
       break;
    }
}
mmenor = mmenor / 10000;
mmaior = mmaior / 10000;
n = String.Format("{0,12:C4}", mmenor);
Console.Write("Menor valor de faturamento: ");
Console.WriteLine(n);
n = String.Format("{0,12:C4}", mmaior);
Console.Write("Maior valor de faturamento: ");
Console.WriteLine(n);
Console.Write("Quantidade de vezes maior do que a media: ");
Console.WriteLine(count);

double mediafunc(double x)
{
    double s = 0;
    s = x / 21;
    return s;
}