using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NextScene : MonoBehaviour
{
    static int  SceneNumber;
   
    public void QuitGame()
    {
        Application.Quit();
        
    }
    public void Reblay()
    {
        SceneManager.LoadSceneAsync(SceneNumber + 2);
        Hit.enemy_number = 2;
    }
    public void NextLevel()
    {
        if (SceneNumber + 3 > 5)
        {
            SceneManager.LoadScene("Level_1");
            SceneNumber = 1;
            Hit.enemy_number = 2;
        }
            
        else
        {
            SceneManager.LoadSceneAsync(SceneNumber + 3);
            SceneNumber++; 
            Hit.enemy_number = 2;
        }
           
    }
    public void Back()
    {
        SceneManager.LoadScene("Level_menu");
        Hit.enemy_number = 2;
    }
    public void Levels()
    {
        SceneManager.LoadScene("Level_menu");

    }
    public void Scene_1()
    {
        SceneManager.LoadScene("Level_1");
        SceneNumber = 1;
        Hit.enemy_number = 2;
    }
    public void Scene_2()
    {
        SceneManager.LoadScene("Level_2");
        SceneNumber = 2;
        Hit.enemy_number = 2;
    }
    public void Scene_3()
    {
        SceneManager.LoadScene("Level_3");
        SceneNumber = 3;
        Hit.enemy_number = 2;
    }
}
