using UnityEngine;

public class DynamicWindController : MonoBehaviour
{
    public WindZone windZone;

    public float windSpeed = 1f;
    public float windStrength = 1f;
    public float windDirectionX = 1f;
    public float windDirectionZ = 0f;

    void Update()
    {
        float variation = Mathf.PerlinNoise(Time.time * 0.5f, 0f);
        windZone.windMain = windSpeed * windStrength + variation * 0.3f;
        windZone.windTurbulence = variation * 0.4f;

        Vector3 dir = new Vector3(windDirectionX, 0f, windDirectionZ);
        transform.rotation = Quaternion.LookRotation(dir.normalized);
    }

    public void SetWindSpeed(float value)
    {
        windSpeed = value;
    }

    public void SetWindStrength(float value)
    {
        windStrength = value;
    }

    public void SetWindDirectionX(float value)
    {
        windDirectionX = value;
    }

    public void SetWindDirectionZ(float value)
    {
        windDirectionZ = value;
    }
}
