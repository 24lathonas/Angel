using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public bool Start;
    public bool Quit;

    void OnMouseDown()
    {
        Start.MainMenu.LoadScene();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void LoadScene()
    {
        Update.SceneManager;
    }

    void SceneManager()
    {
        MainMenu.Update(Start);
    }
}