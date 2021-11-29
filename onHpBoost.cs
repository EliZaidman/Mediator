using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onHpBoost : MonoBehaviour
{


    [SerializeField] private Mediator mediator;

    public void OnClick()
    {
        BoostHpCoomand cmd = new BoostHpCoomand();
        cmd.hp = 30f;
        mediator.Publish<BoostHpCoomand>(cmd);
    }





    

}
