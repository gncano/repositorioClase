using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedFireball : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    private Vector3 direction;

    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
      
        transform.Translate(direction * speed * Time.deltaTime);
    }

    public void setDirection(Vector3 dir)
    {
        direction = dir;
    }
 
}
