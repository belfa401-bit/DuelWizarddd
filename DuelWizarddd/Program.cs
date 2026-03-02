Wizard wizardA = new Wizard("afleB", 20);
Wizard wizardB = new Wizard("Amba", 1000);

Console.WriteLine("Permainan Dimulai...\n");
Console.WriteLine("Statistik Awal");
wizardA.ShowStats();
wizardB.ShowStats();

String Pilihan;

while (true)

{
    Console.Clear();

    Console.WriteLine($"1. {wizardA.Name} Menyerang {wizardB.Name}");
    Console.WriteLine($"2. {wizardB.Name} Menyerang {wizardA.Name}");
    Console.WriteLine($"3. {wizardA.Name} Melakukan Heal");
    Console.WriteLine($"4. {wizardB.Name} Melakukan Heal");

    Console.Write("\nPilihanmu (1/2/3/4): ");
    Pilihan = Console.ReadLine();

    if (Pilihan == "1")
    {
        wizardA.Attack(wizardB);
    }
    else if (Pilihan == "2")
    {
        wizardB.Attack(wizardA);
    }
    else if (Pilihan == "3")
    {
        wizardA.Heal();
    }
    else if (Pilihan == "4")
    {
        wizardB.Heal();
    }
    else
    {
        Console.WriteLine("Pilihanmu Tidak Valid");
    }

    if (wizardA.Energy <= 0 || wizardB.Energy <= 0)
    {
        Console.WriteLine("Permainan Berakhir!");
        if (wizardA.Energy > wizardB.Energy)
        {
            Console.WriteLine($"{wizardB.Name} Berhasil Dikalahkan!");
            Console.WriteLine($"{wizardA.Name} Keluar Sebagai Pemenang!");
        }

        else
        {
            Console.WriteLine($"{wizardA.Name} Berhasil Dikalahkan!");
            Console.WriteLine($"{wizardB.Name} Keluar Sebagai Pemenang!");
        }
        break;
    }
    Console.ReadLine();
}

//wizardA.Attack(wizardB);
//wizardB.Attack(wizardA);

//wizardA.ShowStats();
//wizardB.ShowStats();

//Console.WriteLine("Permainan Selesaii!");

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
