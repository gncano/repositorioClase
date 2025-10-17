using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedFireball : MonoBehaviour
{
    [SerializeField] float speed = 10f;

    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        StartCoroutine(DeleteFireball());
    }

    public void StartDeleteFireball()
    {
        StartCoroutine(DeleteFireball());
    }
    public IEnumerator DeleteFireball()
    {
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }
}
