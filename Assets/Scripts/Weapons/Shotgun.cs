using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : AWeapon
{
    private int m_supershotRate;
    private int m_shotsFired = 0;

    public Shotgun()
    {
        m_name = "Shotgun";
        m_ammo = 10;
        m_supershotRate = 10;
    }

    public override void Shoot()
    {
        base.Shoot();

        if (m_shotsFired % m_supershotRate == 0)
            SetDamage();

        m_shotsFired++;

    }

    private void SetDamage()
    {

    }
}
