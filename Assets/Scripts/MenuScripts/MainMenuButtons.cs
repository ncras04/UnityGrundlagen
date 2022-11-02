using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class MainMenuButtons : MonoBehaviour
{
    [SerializeField] private GameObject m_optionsMenu;
    [SerializeField] private GameObject m_mainMenu;

    public void ChangeScene(int _scene)
    {
        SceneManager.LoadScene(_scene);
    }

    public void OpenOptions()
    {
        m_optionsMenu.SetActive(true);
        m_mainMenu.SetActive(false);
    }

    public void QuitGame()
    {
#if UNITY_STANDALONE
        Application.Quit();
#endif

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#endif
    }





}
