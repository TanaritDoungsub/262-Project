using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class ThrowingKnifeWeapon : WeaponBase
{
    PlayerMove playerMove;

    [SerializeField] GameObject knifePerfab;
    [SerializeField] float spread = 0.5f;

    private void Awake()
    {
        playerMove = GetComponentInParent<PlayerMove>();
    }

    public override void Attack()
    {
        for (int i = 0; i < weaponStats.numberOfAttacks; i++)
        {
            GameObject thrownKnife = Instantiate(knifePerfab);

            Vector3 newKnifePosition = transform.position;
            if (weaponStats.numberOfAttacks > 1)
            {
                newKnifePosition.y -= (spread * (weaponStats.numberOfAttacks - 1)) / 2;
                newKnifePosition.y += i * spread;
            }

            newKnifePosition.y -= (spread * weaponStats.numberOfAttacks) / 2;
            newKnifePosition.y += i * spread;

            thrownKnife.transform.position = newKnifePosition;

            ThrowingKnifeProjectile throwingDaggerProjectile = thrownKnife.GetComponent<ThrowingKnifeProjectile>();
            throwingDaggerProjectile.SetDirection(playerMove.lastHorizontalVector, 0f);
            throwingDaggerProjectile.damage = GetDamage();
        }
    }
}
