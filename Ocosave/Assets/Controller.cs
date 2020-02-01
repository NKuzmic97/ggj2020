﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
    private Animator anim;
    [SerializeField] SoundManager sm;

    [SerializeField] private Transform planetLeft = null;
    [SerializeField] private Transform planetRight = null;

    [SerializeField] private Transform sunLeft = null;
    [SerializeField] private Transform sunRight = null;

    [SerializeField] private GameObject sunKlot = null;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void Update () {
        if (planetLeft.position.x >= sunLeft.position.x && planetRight.position.x <= sunRight.position.x)
        {
            sunKlot.SetActive(true);
        }
        else
        {
            sunKlot.SetActive(false);
        }

        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            if(planetLeft.position.x >= sunLeft.position.x && planetRight.position.x <= sunRight.position.x)
            {
                anim.SetTrigger("IsActive");
            }
            else
            {
                sm.PlayHaha();
            }
        }
	}
}
