using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1f;
    [SerializeField] public int Health = 5;
    [SerializeField] private float cdShoot = 1f;
    public int currentHealth;
    public GameObject redFireballPrefab;
    public int upgradePoints = 1;

    public Lifebar lifebar;
    private PlayerControls playerControls;
    private Vector2 movement;
    private Rigidbody2D rb;
    private Animator animator;
    private SpriteRenderer spriteRenderer;

    [SerializeField] private AudioClip fireballSound;
    private AudioSource audioSource;

    //Uso Awake para que se ejecute antes que el OnEnable
    private void Awake()
    {

        LoadPlayerData();
        
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();

    }

   private void Start()
    {
        lifebar.ChangeHealth(currentHealth);
        playerControls = new PlayerControls();
        playerControls.Enable();
    }

 

    private void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
        if (playerControls != null)
        {
            PlayerInput();
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
        currentHealth -= damage;
        lifebar.ChangeHealth(currentHealth);
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
        PlayerPrefs.SetInt("PlayerPoints", 0);
        PlayerPrefs.SetInt("PlayerHealth", Health);
        PlayerPrefs.Save();
    }

    public void Shoot()
    {
        if (Time.time > cdShoot)
        {
            GameObject projectile = Instantiate(redFireballPrefab, transform.position + new Vector3(0, 0, 0), Quaternion.identity);
            Destroy(projectile, 1f);

            Vector3 mousePos = Input.mousePosition;
            Vector3 playerScreenPoint = Camera.main.WorldToScreenPoint(transform.position);
            Vector3 direction = (mousePos - playerScreenPoint).normalized;
            projectile.GetComponent<RedFireball>().setDirection(direction);
            audioSource.PlayOneShot(fireballSound);

        }

    }

    public void IncreaseUpgradePoints(int points)
    {
        upgradePoints += points;
    }

    public void HealFull()
    {
        currentHealth = Health;
        lifebar.ChangeHealth(currentHealth);
    }

    public void IncreaseMaxHealth(int amount)
    {
        Health += amount;
        currentHealth = Health;
        lifebar.ChangeMaxHealth(Health);
        lifebar.ChangeHealth(currentHealth);
        
    }

    public void ApplySlowEffect()
    {
        StartCoroutine(SlowCoroutine());
    }

    private IEnumerator SlowCoroutine()
    {
        float originalSpeed = moveSpeed;
        moveSpeed = originalSpeed * 0.5f;
        yield return new WaitForSeconds(5f);
        moveSpeed = originalSpeed;
    }

    public void LoadPlayerData()
    {
        currentHealth = PlayerPrefs.GetInt("PlayerHealth");
        lifebar.ChangeHealth(currentHealth);
        upgradePoints = PlayerPrefs.GetInt("PlayerPoints");
        
    }

}
