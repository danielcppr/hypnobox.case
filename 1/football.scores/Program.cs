int.TryParse(Console.ReadLine(), out int n);
int[] teamA = new int[n];


for(int i = 0; i < n; i++)
{
    int.TryParse(Console.ReadLine(), out int numberOfGoals);
    teamA[i] = numberOfGoals;
}

int.TryParse(Console.ReadLine(), out int m);
int[] teamB = new int[m];

if (n < 2 || n > 105 || m < 2 || m > 105)
    throw new Exception("n and m should be between 2 and 105 (included) ");

for (int i = 0; i < m; i++)
{
    int.TryParse(Console.ReadLine(), out int numberOfGoals);

    if (numberOfGoals < 1 || numberOfGoals > 109)
        throw new Exception("Number of goals should be between 1 and 109");

    teamB[i] = numberOfGoals;
}



int[] result = Counts(teamA, teamB);

Console.WriteLine("OUTPUT: ");
foreach(int i in result)
    Console.WriteLine(i);


// talvez uma forma que teria menor complexidade ciclomatica (O(log n)) seria fazer a comparação baseada em busca binaria porém pra isso o array teamA deveria estar ordenado.
// vou implementar como uma busca linear para não precisar fazer a ordenação. (O(n^n)) 


int[] Counts(int[] teamA, int[] teamB)
{
    int[] numberOfMatches = new int[teamB.Length];
    
    for (int i = 0; i < teamB.Length; i++)
    {
        int countGames = 0;
        foreach (int nGoalsA in teamA)
        {
            if (nGoalsA <= teamB[i])
                countGames++;
        }
        numberOfMatches[i] = countGames;
    }

    return numberOfMatches;
}


