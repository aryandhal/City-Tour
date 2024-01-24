using UnityEngine;

public class MouseHandler : MonoBehaviour
{
    public float hoizontalSpeed = 1f;
    public float verticalSpeed = 1f;

    float xRotation = 0f;
    float yRotation = 0f;

     void Start()
    {
        
    }

    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * hoizontalSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * verticalSpeed;

        yRotation += mouseX;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90, 90);

        transform.eulerAngles = new Vector3(xRotation, yRotation, 0.0f);
    }

}
