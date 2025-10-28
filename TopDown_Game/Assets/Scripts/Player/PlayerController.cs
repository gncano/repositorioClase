using System;
using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1f;
    [SerializeField] private int Health = 5;
    [SerializeField] private float cdShoot = 1f;
    private int currentHealth;
    public GameObject redFireballPrefab;

    public Lifebar lifebar;
    private PlayerControls playerControls;
    private Vector2 movement;
    private Rigidbody2D rb;
    private Animator animator;
    private SpriteRenderer spriteRenderer;

    //Uso Awake para que se ejecute antes que el OnEnable
    private void Awake()
    {
        playerControls = new PlayerControls();
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        currentHealth = Health;

    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void Update()
    {
        PlayerInput();
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    //FixedUpdate es como el Update pero en vez de llamarlo cada frame lo hace en unos intervalos de tiempo determinados
    private void FixedUpdate()
    {
        AdjustPlayerFacingDirection();
        Move();
    }


    //Metodo para que el personaje mire en la direccion del raton   
    private void AdjustPlayerFacingDirection()
    {
        Vector3 mousePos = Input.mousePosition;
        Vector3 playerScreenPoint = Camera.main.WorldToScreenPoint(transform.position);

        if (mousePos.x < playerScreenPoint.x)
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }
        
    }

    private void PlayerInput()
    {
        movement = playerControls.Movement.Move.ReadValue<Vector2>();

        animator.SetFloat("moveX", movement.x);
        animator.SetFloat("moveY", movement.y);
    }

    private void Move()
    {
        rb.MovePosition(rb.position + movement * (moveSpeed * Time.fixedDeltaTime));
    }

    public void LoseLife(int damage)
    {
        Health -= damage;
        lifebar.ChangeHealth(Health);
        if (Health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
       

    }

    public void Shoot()
    {
        if (Time.time > cdShoot)
        {
         GameObject projectile = Instantiate(redFireballPrefab, transform.position + new Vector3(0, 0,0), Quaternion.identity);
         Destroy(projectile, 1f);

         Vector3 mousePos = Input.mousePosition;
         Vector3 playerScreenPoint = Camera.main.WorldToScreenPoint(transform.position);
         Vector3 direction= (mousePos-playerScreenPoint).normalized;
         projectile.GetComponent<RedFireball>().setDirection(direction);
         
        }

    }


}
