using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuBehaviour : MonoBehaviour
{
    public AudioClip MenuAudioClip;
    public AudioSource MenuAudioSource;
    public GameObject panel;

    public void NewGame()
    {
        SceneManager.LoadScene("Mythos_Map");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("1.MainMenu");
    }

    public void Credits()
    {
        SceneManager.LoadScene("2.Credits");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Resume()
    {
        panel.SetActive(false);
        Time.timeScale = 1.0f;
    }

    void Start()
    {
        MenuAudioSource.clip = MenuAudioClip;
        MenuAudioSource.Play();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (panel.activeSelf)
                Resume();

            else
            {
                Time.timeScale = 0f;
                panel.SetActive(true);
            }

        }
    }
}
