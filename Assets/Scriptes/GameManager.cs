using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
    }
    public void Load(string sceneName)
    {
        Time.timeScale = 1;
        if (sceneName == "")
            sceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(sceneName);
    }
    public void DropSave()
    {
        PlayerPrefs.DeleteAll();
    }
}
