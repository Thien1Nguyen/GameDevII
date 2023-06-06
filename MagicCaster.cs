public class MagicCaster : Enemy
{
    public Attack fireBall = new Attack("FireBall", 25);
    public Attack lightningBolt  = new Attack("Ligtning Bolt", 20);
    public Attack staffStrike = new Attack("Staff Strike", 10);
    public MagicCaster(string name) : base(name, 80)
    {
        AttackList = new List<Attack>{fireBall, lightningBolt, staffStrike};
    }

    public void Heal(Enemy Target, int healPower = 40)
    {
        Target.Health += healPower;
        Console.WriteLine($"{Name} use Heal on {Target.Name}, {Target.Name} has recovered {healPower} recovered health!!");
    }
}