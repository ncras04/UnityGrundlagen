using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AWeapon
{
    public string Name => m_name;

    protected float m_damage;
    protected string m_name;

    protected int m_ammo;
    protected AWeapon()
    {

    }
    public virtual void Shoot()
    {
        Debug.Log("I am a " + m_name + "!");
    }

}
