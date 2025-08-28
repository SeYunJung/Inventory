using System.Collections.Generic;

public class Player 
{
    public string Id { get; private set; }
    public string Job {  get; private set; }
    public int Gold { get; private set; }
    public int Level { get; private set; }
    public int Experience { get; private set; }
    public string Description { get; private set; }
    public List<int> Inventory { get; private set; }
    public int Attack {  get; private set; }
    public int Defense { get; private set; }
    public int Health { get; private set; }
    public int Critical { get; private set; }

    public Player()
    {
        Id = "코딩노예";
        Job = "Warrior";
        Gold = 10000;
        Level = 1;
        Experience = 2;
        Description = "코딩의 노예 코딩의 노예 코딩의 노예 코딩의 노예 코딩의 노예";
        Inventory = new List<int>() { 3, 0, 4, 1, 2 };

        /// inventory
        /// 0 : 검
        /// 1 : 방패
        /// 2 : 활
        /// 3 : 투구
        /// 4 : 반지 

        Attack = 10;
        Defense = 5;
        Health = 100;
        Critical = 15;
    }
}
