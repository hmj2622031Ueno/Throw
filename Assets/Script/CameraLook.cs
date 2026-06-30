using UnityEngine;
using UnityEngine.InputSystem;

public class CameraLook : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float sensitivity = 0.2f;
    [SerializeField] private float distance = 11f;
    [SerializeField] private float height = 13f;

    private float yaw = 0f;
    private float pitch = 20f;

    private void LateUpdate()
    {
        if(Mouse.current.rightButton.wasPressedThisFrame)
        {
            yaw = target.eulerAngles.y;
        }

        Vector2 mouse = Mouse.current.delta.ReadValue();

        yaw += mouse.x * sensitivity;
        pitch -= mouse.y * sensitivity;

        pitch = Mathf.Clamp(pitch, -20f, 70f);

        Quaternion rotation = Quaternion.Euler(pitch, yaw, 0);

        Vector3 offset = rotation * new Vector3(0, height, -distance);

        transform.position = target.position + offset;

        //transform.LookAt(target);
        transform.rotation = rotation;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
