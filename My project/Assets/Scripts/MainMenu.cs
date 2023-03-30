using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public bool Start;
    public bool Quit;

    void OnMouseDown()
    {
        Start.MainMenu.LoadScene;
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void LoadScene()
    {
        #pragma warning disable format
        Update;
        #pragma warning restore formatdate.SceneManager// Fix later
        
    }

    void SceneManager()
    {
        MainMenu.Update(Start);
    }
}