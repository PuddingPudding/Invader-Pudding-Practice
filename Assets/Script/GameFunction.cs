using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameFunction : MonoBehaviour {

    public static bool isGaming= true;
    public GameObject menu;

	// Use this for initialization
	void Start ()
    {
        menu.SetActive(false);
        resume();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isGaming == true)
            {
                pause();
            }
            else
            {
                resume();
            }
        }
    }

    public void pause()
    {
        Time.timeScale = 0; //暫停
        isGaming = false;
        menu.SetActive(true);
    }

    public void resume()
    {
        Time.timeScale = 1;
        isGaming = true;
        menu.SetActive(false);
    }

    public void restart()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single); //重新載入該頁面，但注意，timeScale並不會還原
    }

    public void exit()
    {
        Application.Quit();
    }
}
