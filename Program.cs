// See https://aka.ms/new-console-template for more information


MeleeFighter warrior = new MeleeFighter("Orc Warrior");

RangeFighter ranger = new RangeFighter("Legolas");

MagicCaster mage = new MagicCaster("Gandalf");

warrior.PerformAttack(ranger, warrior.kick);
warrior.Rage(ranger);
ranger.PerformAttack(warrior, ranger.arrowPewPew);
ranger.Dash();
ranger.PerformAttack(warrior, ranger.arrowPewPew);
mage.Heal(ranger);
mage.Heal(mage);

