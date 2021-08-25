using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject _black;
    [SerializeField] private GameObject _menu;
    public void Toggle()
    {
        bool on = !_black.activeSelf;
        Time.timeScale = on ?  0 : 1;
        _black.SetActive(on);
        _menu.SetActive(on);
    }
}
