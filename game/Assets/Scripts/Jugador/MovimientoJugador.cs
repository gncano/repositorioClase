using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{

    [SerializeField] private float velocidad = 5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * horizontal * velocidad * Time.deltaTime);
        transform.Translate(Vector3.up * vertical * velocidad * Time.deltaTime);
    }
}
