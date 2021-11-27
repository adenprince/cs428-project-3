using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        Debug.Log("Change scene to " + sceneName);
        SceneManager.LoadScene(sceneName);
    }
}
