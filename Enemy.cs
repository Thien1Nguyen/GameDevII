public class Enemy
{
    public string Name {get;set;}
    public int Health{get;set;}
    public List<Attack> AttackList = new List<Attack>();

    Random rand = new Random();

    public Enemy(string name,  int health = 100)
    {
        Name = name;
        Health = health;
    }

    public string RandomAttack()
    {
        return AttackList[rand.Next(0, AttackList.Count)].Name;
    }

    public void AddAttack(Attack attack)
    {
        AttackList.Add(attack);
    }

    public void ShowAttackList()
    {
        AttackList.ForEach(attack => Console.WriteLine($"{attack.Name} - {attack.DamageAmount} damage"));
    }

    
    public virtual void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        Target.Health = Target.Health - ChosenAttack.DamageAmount;
        Console.WriteLine($"{Name} attacks {Target.Name}, dealing {ChosenAttack.DamageAmount} damage and reducing {Target.Name}'s health to {Target.Health}!!");
    }

}