using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher_Button : MonoBehaviour
{
    [SerializeField] private string sceneName;

    public void LoadScene()
    {
            SceneManager.LoadScene(sceneName);
    }
}