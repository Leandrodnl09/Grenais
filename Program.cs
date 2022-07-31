// Exercício do site URI "Grenais"

int NovoJogo, Cont, TotalGolsInter, TotalGolsGremio, VitoriasInter, VitoriasGremio, Empate;

string[] grenal = Console.ReadLine().Split(' ');
int GolsInter = int.Parse(grenal[0]);
int GolsGremio = int.Parse(grenal[1]);

Cont = 0;
NovoJogo = 1;
TotalGolsInter = 0;
TotalGolsGremio = 0;
VitoriasInter = 0;
VitoriasGremio = 0;
Empate = 0;

while (NovoJogo == 1)
{
    TotalGolsInter = TotalGolsInter + GolsInter;
    TotalGolsGremio = TotalGolsGremio + GolsGremio;
    Cont = Cont + 1;

    if (GolsInter > GolsGremio)
    {
        VitoriasInter = VitoriasInter + 1;
    }
    else if (GolsGremio > GolsInter)
    {
        VitoriasGremio = VitoriasGremio + 1;
    }
    else if (GolsGremio == GolsInter)
    {
        Empate = Empate + 1;
    }

    Console.WriteLine("Novo grenal (1-sim 2-nao)");
    NovoJogo = int.Parse(Console.ReadLine());

    if (NovoJogo == 1)
    {
        grenal = Console.ReadLine().Split(' ');
        GolsInter = int.Parse(grenal[0]);
        GolsGremio = int.Parse(grenal[1]);
    }
}
Console.WriteLine(Cont + " grenais");
Console.WriteLine("Inter:" + VitoriasInter);
Console.WriteLine("Gremio:" + VitoriasGremio);
Console.WriteLine("Empates:" + Empate);

if (VitoriasInter > VitoriasGremio)
{
    Console.WriteLine("Inter venceu mais");
}
else if (VitoriasGremio > VitoriasInter)
{
    Console.WriteLine("Gremio venceu mais");
}
else if (VitoriasGremio == VitoriasInter)
{
    Console.WriteLine("Nao houve vencedor");
}