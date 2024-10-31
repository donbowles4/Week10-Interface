using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInterface : MonoBehaviour
{
    void Start()
    {
        //IAttack player = new Player();
        //player.Attack();

        AttackObject(new Player());
        AttackObject(new Enemy());
    }

    void AttackObject(IAttack iAttack)
    {
        iAttack.Attack();
    }

}
