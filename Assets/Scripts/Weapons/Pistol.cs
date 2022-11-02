using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : AWeapon
{
    private int m_chamberFailRate;
    public Pistol()
    {
        m_name = "Pistol";
        m_ammo = 10;
        m_chamberFailRate = 2082;
    }

    public void FancyTricks()
    {
        Debug.Log("I am so dextrous!!");
    }
}
