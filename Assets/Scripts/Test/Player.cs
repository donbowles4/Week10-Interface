using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player: IAttack
{
    public int Damage { get; set; }

    public void Attack()
    {
        Damage = 2;
        Debug.Log("Player Damage: " + Damage);
    }

}
