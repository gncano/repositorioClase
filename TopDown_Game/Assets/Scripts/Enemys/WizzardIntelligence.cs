using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizzardIntelligence : MonoBehaviour
{

    private int health = 20;

    [Header("Movement Settings")]
    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private Vector2 areaMin;
    [SerializeField] private Vector2 areaMax;
    private Vector2 targetPosition;
    private bool canMove = true;
    private SpriteRenderer mySpriteRenderer;

    [Header("Attack Settings")]
    [SerializeField] private GameObject blueFireballPrefab;
    [SerializeField] private float fireballCooldown = 2f;
    private bool canShoot = true;
    private GameObject playerObject;

    [SerializeField] private float meleeAttackRadius = 4.5f;
    [SerializeField] private LayerMask playerLayer;

    [SerializeField] private Transform player;  
    [SerializeField] private float teleportDistance = 1.5f;

    [Header("Animation")]
    private Animator animator;

    
    

    private void Awake()
    {
        animator = GetComponent<Animator>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        
    }


    private void Start()
    {
        ChooseNewTarget();
        StartCoroutine(AttackRoutine());
    }

    private void Update()
    {
        MoveWithinArea();
        AdjustWizzardFacingDirection();
    }

    private void MoveWithinArea()
    {
        if (!canMove) return;  

        transform.position = Vector2.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

        if (Vector2.Distance(transform.position, targetPosition) < 0.2f)
        {
            ChooseNewTarget();
        }
    }

    private void ChooseNewTarget()
    {
        targetPosition = new Vector2(
            Random.Range(areaMin.x, areaMax.x),
            Random.Range(areaMin.y, areaMax.y)
        );

        //animator.SetTrigger("Run");
    }

    private IEnumerator AttackRoutine()
    {
        while (true)
        {
            if (canShoot)
            {
                yield return new WaitForSeconds(fireballCooldown);
 
                float chance = Random.Range(0f, 1f);

                if (chance <= 0.7f)
                {
                    animator.SetTrigger("Attack2");
                    Invoke("ShootBlueFireball", .8f);
                }
                else
                {
                    TeleportAndMeleeAttack();
                }
            }
            yield return null;
        }
    }


    private void ShootBlueFireball()
    {
        
        Vector3 spawnPosition = transform.position + transform.up * 0.5f;
        GameObject projectile = Instantiate(blueFireballPrefab, spawnPosition, Quaternion.identity);

        Vector3 direction = (player.transform.position - spawnPosition).normalized;
        projectile.GetComponent<BlueFireball>().setDirection(direction);
        Destroy(projectile, 1f);
        
    }



    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireCube((areaMin + areaMax) / 2f, areaMax - areaMin);
        Gizmos.DrawWireSphere(transform.position, meleeAttackRadius);
    }

    private void TeleportAndMeleeAttack()
    {
        Vector3 directionBehindPlayer = (transform.position - player.position).normalized;
        Vector3 teleportPosition = player.position + directionBehindPlayer * teleportDistance;
        transform.position = teleportPosition;

        StartCoroutine(WaitAndAttackCoroutine(.1f));
        

    }

    private IEnumerator WaitAndAttackCoroutine(float waitTime)
    {
        canMove = false;
        yield return new WaitForSeconds(waitTime);

        animator.SetTrigger("Attack1");

        yield return new WaitForSeconds(1f);
        Collider2D hit = Physics2D.OverlapCircle(transform.position, meleeAttackRadius, playerLayer);

        if (hit != null)
        {
            Debug.Log("Player hit by melee attack!");
            hit.GetComponent<PlayerController>().LoseLife(3);
        }
        else
        {
            Debug.Log("Player dodged melee attack.");
        }
        canMove = true;
    }

    private void AdjustWizzardFacingDirection()
    {
        Vector3 playerPos = GetPlayerPosition();
        Vector3 wizzardScreenPoint = transform.position;

        if (playerPos.x < wizzardScreenPoint.x)
        {
            mySpriteRenderer.flipX = true;
        }
        else
        {
            mySpriteRenderer.flipX = false;
        }

    }

    private Vector2 GetPlayerPosition()
    {
        return GameObject.FindGameObjectWithTag("Player").transform.position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {

            PlayerController player = collision.gameObject.GetComponent<PlayerController>();
            player.LoseLife(3);

        }

        if (collision.gameObject.tag == "Fireball")
        {
            RedFireball fireball = collision.gameObject.GetComponent<RedFireball>();
            health -= 1;
            if (health <= 0)
            {
                Destroy(gameObject);
            }
            fireball.destroyFireball();

        }

    }

}
