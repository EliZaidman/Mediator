using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostHpCoomand : Command
{
    public float hp { get; set; }
    private void onBoostHP(BoostHpCoomand c)
    {
        hp = c.hp;
    }
}
