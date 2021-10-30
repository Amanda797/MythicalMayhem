using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    private Toggle m_MenuToggle;
	private float m_TimeScaleRef = 1f;
    private float m_VolumeRef = 1f;
    private bool m_Paused;


    void Awake()
    {
       // MenuToggle = GetComponent <Toggle> ();
	}


    private void MenuOn ()
    {
      //m_TimeScaleRef = Time.timeScale;
     // Time.timeScale = 0f;

     // m_VolumeRef = AudioListener.volume;
     // AudioListener.volume = 0f;

     // m_Paused = true;
    }


    public void MenuOff ()
    {
     // Time.timeScale = m_TimeScaleRef;
     // AudioListener.volume = m_VolumeRef;
     // m_Paused = false;
    }


    public void OnMenuStatusChange ()
    {
     // if (m_MenuToggle.isOn && !m_Paused)
     // {
      //    MenuOn();
     // }
     // else if (!m_MenuToggle.isOn && m_Paused)
     // {
      //    MenuOff();
    //  }
    }


#if !MOBILE_INPUT
	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Escape))


		{if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }

		   // m_MenuToggle.isOn = !m_MenuToggle.isOn;
           // Cursor.visible = m_MenuToggle.isOn;//force the cursor visible if anythign had hidden it
		}
	}

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

    }
    void Pause()
    {

        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
#endif

}
