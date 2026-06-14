using UnityEngine;

public class WindPhysicsController : MonoBehaviour
{
    public DynamicWindController windController;
    public float forceMultiplier = 1f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 dir = new Vector3(windController.windDirectionX, 0f, windController.windDirectionZ);
        Vector3 force = dir.normalized * windController.windSpeed * windController.windStrength * forceMultiplier;
        rb.AddForce(force, ForceMode.Force);
    }
}
