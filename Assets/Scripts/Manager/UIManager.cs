using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    static public UIManager Instance { get; private set; }

    [SerializeField] private TextMeshProUGUI m_text;

    private void Awake()
    {
        if (Instance != null)
        { 
            Destroy(this.gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    public void SetText(string _newText)
    {
        m_text.text = _newText;
    }
}
