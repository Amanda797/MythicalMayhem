using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    //Singleton set up, instance commonly used
    public static GameManager instance;

    public GameObject currentObject;

    public void Awake()
    {
        instance = this;
    }

    // public void PauseGame()
   // {
       // PauseMenu.SetActive(!PauseMenu.activeSelf);
      //  if (PauseMenu.activeSelf)
       // {
       //     Time.timeScale = 0f;
      //  }
     //   else
     //   {
     //       Time.timeScale = 1f;
      //  }
   // }

    // If Game Manager is in Scene, Players can presss esc key to quit the game
    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
