using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuController : MonoBehaviour
{
    public void playGame()
    {
        Debug.Log("Scene loading");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
    public void Music()
    {
        AudioSource music = GameObject.FindGameObjectWithTag("Music").GetComponent<AudioSource>();
        if (music.isPlaying)
        {
            Debug.Log("Pausing music...");
            music.Pause();
        }
        else
        {
            Debug.Log("Playing music...");
            music.Play();
        }
    }
}
