public class RangeFighter : Enemy
{
    public Attack arrowPewPew  = new Attack("Arrow Pew Pew", 20);
    public Attack knifeThrow  = new Attack("Knife Throw", 15);
    public int Distance;
    public RangeFighter(string name, int distance = 5) : base(name)
    {
        Distance = distance;
        AttackList = new List<Attack>{arrowPewPew, knifeThrow};
    }

    public override void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        if(Distance < 10)
        {
            Console.WriteLine($"{Name} is too close to the target to perform an attack");
        }
        else
        {
            Target.Health = Target.Health - ChosenAttack.DamageAmount;
            Console.WriteLine($"{Name} attacks {Target.Name} with {ChosenAttack.Name}, dealing {ChosenAttack.DamageAmount} damage and reducing {Target.Name}'s health to {Target.Health}!!");
        }
        
    }

    public void Dash()
    {
        Distance = 20;
        Console.WriteLine($"{Name} has dashed away and gained {Distance} feet from the target");
    }
}