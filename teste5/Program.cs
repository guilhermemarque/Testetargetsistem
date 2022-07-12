string[] palavra = new string[7] {"A","b","a","c","a","t","e"};

string[] palavrainv = new string[7];

int j = 6;
for(int i = 0; i < 7; i++)
{
    palavrainv[i]=palavra[j];
    j--;
}
for (int i = 0; i < 7; i++)
    Console.Write(palavrainv[i]);