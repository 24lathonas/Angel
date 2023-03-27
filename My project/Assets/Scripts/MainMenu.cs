using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public bool Start;
    public bool Quit;

    void OnMouseDown()
    {
        MainMenu.LoadScene();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void LoadScene()
    {
        MainMenu.SceneManager;
    }

    void SceneManager()
    {
        MainMenu.SceneManager(Start);
    }
}