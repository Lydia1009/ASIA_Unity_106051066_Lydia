using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform cam, target;

    public float speed = 2;

    private void Update()
    {
        Vector3 pos = Vector3.Lerp(cam.position, target.position, 0.1f * Time.deltaTime * speed);

        cam.position = pos;
    }
}
