using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 5f;
    public Vector3 offset = new Vector3(0, 0, 1); // el offset es para evitar que la camara de errores
 
    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            return;
        }
        Vector3 Position = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, Position, smoothSpeed * Time.deltaTime);
    }

   
}
