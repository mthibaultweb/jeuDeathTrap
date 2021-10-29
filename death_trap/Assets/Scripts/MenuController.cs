using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Start is called before the first frame update
     
    public void QuitGame()
    {
        Debug.Log("quit");
        Application.Quit();
    }

    public void PlayInto()
    {
        SceneManager.LoadScene(2);
    }

    public void PlayLvl1()
    {
        SceneManager.LoadScene(3);
    }

        public void PlayLvl2()
    {
        SceneManager.LoadScene(4);
    }

    public void Credits()
    {
        SceneManager.LoadScene(1);
    }

    public void BackHome()
    {
        Debug.Log("menu");
        SceneManager.LoadScene(0);
    }

    public void GameOver()
    {
        SceneManager.LoadScene(5);
    }

    public void YouWin()
    {
        SceneManager.LoadScene(6);
    }

    
}
