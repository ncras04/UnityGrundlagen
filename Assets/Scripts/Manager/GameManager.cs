using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static public GameManager Instance { get; private set; }

    [SerializeField] private float m_time;

    private int m_score;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(this.gameObject);
            return;
        }

        Instance = this;

        DontDestroyOnLoad(this.gameObject);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;


    }
}
