using UnityEngine;

public class SceneVariationsMenu : MonoBehaviour
{
    public void ToggleMenu()
    {
        gameObject.SetActive(!gameObject.activeInHierarchy);
    }
}
