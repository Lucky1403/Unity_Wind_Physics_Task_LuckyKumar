using UnityEngine;

public class WindArrow : MonoBehaviour
{
    public DynamicWindController windController;

    void Update()
    {
        Vector3 dir = new Vector3(windController.windDirectionX, 0f, windController.windDirectionZ);
        if (dir != Vector3.zero)
        {
            float angle = Mathf.Atan2(dir.x, dir.z) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
        }
    }
}