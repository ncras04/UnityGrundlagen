using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    private Rigidbody m_rb;
    [SerializeField] private Transform m_camera;

    private Vector3 m_dir;
    private float m_yRot;
    [SerializeField] private float m_forceQ;
    [SerializeField] private float m_mouseSens;


    private AWeapon m_currentWeapon;


    private void Awake()
    {
        m_rb = GetComponentInParent<Rigidbody>();
    }

    public void WeaponPickUp(WeaponType _type)
    {
        Debug.Log("I picked up a weapon!");

        switch (_type)
        {
            case WeaponType.PISTOL:
                m_currentWeapon = new Pistol();
                break;
            case WeaponType.SHOTGUN:
                m_currentWeapon = new Shotgun();
                break;
            default:
                m_currentWeapon = null;
                break;
        }

        UIManager.Instance.SetText("Current Weapon: " + m_currentWeapon.Name);
    }

    private void Update()
    {
        DetermineDirection();
        RotateCamera();

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (m_currentWeapon == null)
                return;

            m_currentWeapon.Shoot();
        }
    }

    private void DetermineDirection()
    {
        m_dir = Input.GetAxisRaw("Horizontal") * transform.right
              + Input.GetAxisRaw("Vertical") * transform.forward;

        transform.localEulerAngles += new Vector3(0, CalcAxis("Mouse X"), 0);
    }
    private void RotateCamera()
    {
        m_yRot -= CalcAxis("Mouse Y");
        m_camera.localEulerAngles = new Vector3(Mathf.Clamp(m_yRot, -90f, 90f), 0, 0);
    }

    private void FixedUpdate()
    {
        m_rb.AddForce(m_dir * m_forceQ * Time.fixedDeltaTime, ForceMode.VelocityChange);
    }
    private float CalcAxis(string _axis)
    {
        return Input.GetAxis(_axis) * m_mouseSens * Time.deltaTime;
    }

}
