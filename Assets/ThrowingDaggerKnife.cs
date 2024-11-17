using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class ThrowingDaggerKnife : MonoBehaviour
{
    [SerializeField] float timeToAttack;
    float timer;

    PlayerMove playerMove;

    [SerializeField] GameObject knifePerfab;

    private void Awake()
    {
        playerMove = GetComponentInParent<PlayerMove>();
    }
    private void Update()
    {
        if (timer < timeToAttack)
        {
            timer += Time.deltaTime;
            return;
        }

        timer = 0;
        SpawnKnife();
    }

    private void SpawnKnife()
    {
        GameObject thrownKnife = Instantiate(knifePerfab);
        thrownKnife.transform.position = transform.position;
        thrownKnife.GetComponent<ThrowingDaggerProjectile>().SetDirection(playerMove.lastHorizontalVector, 0f);
    }
}
