using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public bool Start;
    public bool Quit;

    void OnMouseDown()
    {
        SceneManager.LoadScene();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void LoadScene()
    {
        SceneBuildIndex.SceneManagement.LoadSceneMode;
    }

    int mode()
    {
        MainMenu.LoadScene(Start);
    }
}