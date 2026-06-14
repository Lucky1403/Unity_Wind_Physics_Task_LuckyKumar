using UnityEngine;

public class StreetLampController : MonoBehaviour
{
    public Light lampLight;
    public float maxIntensity = 2f;
    public Color lampColor = new Color(1f, 0.8f, 0.4f);

    void Start()
    {
        lampLight.color = lampColor;
        lampLight.intensity = 0f;
    }

    public void SetLampState(bool on)
    {
        lampLight.intensity = on ? maxIntensity : 0f;
    }
}
