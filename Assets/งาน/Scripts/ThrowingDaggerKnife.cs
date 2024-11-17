using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class ThrowingDaggerKnife : WeaponBase
{
    PlayerMove playerMove;

    [SerializeField] GameObject knifePerfab;

    private void Awake()
    {
        playerMove = GetComponentInParent<PlayerMove>();
    }

    public override void Attack()
    {
        GameObject thrownKnife = Instantiate(knifePerfab);
        thrownKnife.transform.position = transform.position;
        thrownKnife.GetComponent<ThrowingDaggerProjectile>().SetDirection(playerMove.lastHorizontalVector, 0f);
    }
}
