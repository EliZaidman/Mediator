using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpHandler : MonoBehaviour
{
   [SerializeField] private Mediator mediator;
    void Start()
    {
        mediator.Subscribe<hpChangedCMD>(OnHpChanged);
    }

    private void OnHpChanged(hpChangedCMD c)
    {
        GetComponent<Text>().text = c.hp.ToString("0");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
