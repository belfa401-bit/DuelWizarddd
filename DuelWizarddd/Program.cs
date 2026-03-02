Wizard wizardA = new Wizard("afleB", 20);
Wizard wizardB = new Wizard("Amba", 1000);

Console.WriteLine("Permainan Dimulai...\n");
Console.WriteLine("Statistik Awal");
wizardA.ShowStats();
wizardB.ShowStats();

wizardA.Attack(wizardB);
wizardB.Attack(wizardA);

wizardA.ShowStats();
wizardB.ShowStats();

Console.WriteLine("Permainan Selesaii!");

public class Wizard
{
    //Field
    public string Name;
    public int Energy;
    public int Damage;


    //Constructor
    public Wizard(string name, int damage)
    {
        Name = name;
        Energy = 100;
        Damage = damage;
    }

    //Deklarasi Method
    public void ShowStats()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Energy: {Energy}\n");
    }

    public void Attack(Wizard enemyObj)
    {
        enemyObj.Energy -= Damage;
        Console.WriteLine($"{Name} menyerang {enemyObj.Name}");
        Console.WriteLine($"Sisa energy {enemyObj.Name}: {enemyObj.Energy}\n");
    }

    public void Heal()
    {
        if (Energy >= 100)
        {
            Console.WriteLine("Gagal Melakukan Heal. Energi Sudah Mencapai Maksimum!");
        }
        else
        {
            if (Energy > 95)
            {
                Energy = 100;
            }
            else
            {
                Energy += 5;
            }
            Console.WriteLine($"(Name) Berhasil Melakukan Heal. Energi Meningkat Menjadi: {Energy}");
        }
    }
}
