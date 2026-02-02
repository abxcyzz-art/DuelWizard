
Wizard wizardA = new Wizard("Harre Potta", 20);
Wizard wizardB = new Wizard(" Youre a Wizard Harry", 30);

Console.WriteLine("Permainan Dimulai...\n");
wizardA.ShowStat();
wizardB.ShowStat();

wizardA.Attack(wizardB);
wizardB.Attack(wizardA); 
wizardA.Attack(wizardB);


public class Wizard
{
    public string Name;
    public int Energi;
    public int Damage;

    public Wizard(string name, int damage)
    {
        Name = name;
        Energi = 100;
        Damage = damage;
    }

    public void ShowStat()
    {
        Console.WriteLine("Statistik Wizard");
        Console.WriteLine($"Nama: {Name}, Energi: {Energi} \n");
    }

    public void Attack(Wizard wizardLawanObj)
    {
        wizardLawanObj.Energi -= Damage;
        Console.WriteLine($"{Name} menyerang {wizardLawanObj.Name}");
        Console.WriteLine($"Sisa energi {wizardLawanObj.Name} adalah {wizardLawanObj.Energi}");
    }

}
