using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenesfazet : MonoBehaviour

{
    
    
    public void Starto()
    {
        SceneManager.LoadScene(1);
    }
    public void NextLvl()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1;
    }

    public void Quit()
    {
        Application.Quit();
    }
}