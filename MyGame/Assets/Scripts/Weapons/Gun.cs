using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Gun : Weapon
{
    [SerializeField] Bullet bullet;
    public override void Shoot()
    {
        if (Time.time - lastTimeShoot > rateOfFire) 
        {
            Bullet tmpBullet = Instantiate(bullet, tipOfWeapon.position, tipOfWeapon.rotation);
            tmpBullet.Setup(demage);
            
            lastTimeShoot = Time.time;
            Debug.Log("pucaj");
        }
    }

}
