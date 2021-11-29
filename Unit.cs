using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    [SerializeField] private float HP = 30.0f;
    [SerializeField] private Mediator mediator;
    // Start is called before the first frame update

    void onBoostHP(BoostHpCoomand c)
    {
        HP = c.hp;
    }
    void Start()
    {
        mediator.Subscribe<BoostHpCoomand>(onBoostHP);
    }

    // Update is called once per frame
    void Update()
    {
        HP -= Time.deltaTime * 2f;
        hpChangedCMD cmd = new hpChangedCMD();
        cmd.hp = HP;
        mediator.Publish(cmd);
    }
}
