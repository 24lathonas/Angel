using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    //https://www.c-sharpcorner.com/article/create-start-menu-scene-using-c-sharp-script-in-unity-3d/

    public void PlayGame()
    {
        Application.LoadLevel("GameScene");
    }
    
    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.LoadLevel("Quit");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
