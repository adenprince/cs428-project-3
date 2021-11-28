using UnityEngine;

public class Lamp : MonoBehaviour
{
    public GameObject lampLight;
    public Renderer bulb;
    public Material onMaterial;
    public Material offMaterial;

    bool maxReached = true;

    public void MaxReached()
    {
        maxReached = true;
    }

    public void MinReached()
    {
        if (maxReached)
        {
            lampLight.SetActive(!lampLight.activeInHierarchy);

            if (lampLight.activeInHierarchy)
            {
                bulb.material = onMaterial;
            }
            else
            {
                bulb.material = offMaterial;
            }

            maxReached = false;
        }
    }
}
