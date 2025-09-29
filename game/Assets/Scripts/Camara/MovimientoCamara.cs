using UnityEngine;

public class MovimientoCamara : MonoBehaviour
{

    [SerializeField] private float velocidadCamara = 5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * horizontal * velocidadCamara * Time.deltaTime);
        transform.Translate(Vector3.up * vertical * velocidadCamara * Time.deltaTime);
    }
}
