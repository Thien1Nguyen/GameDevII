public class MeleeFighter : Enemy
{
    public Attack punch  = new Attack("Punch", 20);
    public Attack kick  = new Attack("Kick", 15);
    public Attack tackle = new Attack("Tackle", 25);

    public MeleeFighter(string name) : base(name, 120)
    {
        AttackList = new List<Attack>{punch, kick, tackle};
    }

    Random rand = new Random();
    public void Rage(Enemy Target)
    {
        int randIdx = rand.Next(AttackList.Count);
        int damage = (AttackList[randIdx].DamageAmount + 10);
        Target.Health = Target.Health - damage;
        Console.WriteLine($"{Name} use Rage and attacks {Target.Name}, dealing {damage} damage and reducing {Target.Name}'s health to {Target.Health}!!"); 
    }
}