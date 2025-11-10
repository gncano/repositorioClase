using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueFireball : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    private Vector3 direction;

    private Rigidbody2D rb;
    private Collider2D col;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
       
    }

    private void Start()
    {
        col.isTrigger = true;
        StartCoroutine(EnableCollisionAfterDelay());
    }
    // Update is called once per frame
    void Update()
    {

        transform.Translate(direction.normalized * speed * Time.deltaTime);
    }

    public void setDirection(Vector3 dir)
    {
        direction = dir.normalized;
    }

    private IEnumerator EnableCollisionAfterDelay()
    {
        yield return new WaitForSeconds(.1f);
        col.isTrigger = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {

            PlayerController player = collision.gameObject.GetComponent<PlayerController>();
            player.LoseLife(1);
            player.ApplySlowEffect();
            Destroy(gameObject);

        }
    }
   
}
