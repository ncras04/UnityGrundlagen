using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    [SerializeField] private GameObject m_mainMenu;
    [SerializeField] private GameObject m_optionsMenu;

    [SerializeField] private AudioMixer m_mainMixer;

    private void Awake()
    {
        Slider tmp = GetComponentInChildren<Slider>();
        m_mainMixer.GetFloat("MainVolume", out float value);
        tmp.value = Mathf.Pow(10,value * 0.05f);
    }

    public void CloseOptions()
    {
        m_mainMenu.SetActive(true);
        m_optionsMenu.SetActive(false);
    }

    public void SetVolume(float _value)
    {
        m_mainMixer.SetFloat("MainVolume", Mathf.Log10(_value) * 20);
    }

}
