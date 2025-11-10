using System.Collections;
using UnityEngine;

public class WarriorInteligence : MonoBehaviour
{

    [SerializeField] private float health = 3;
    private float playerDamage = 1f;

    private Animator myAnimator;
    private SpriteRenderer mySpriteRenderer;

    //Estados del enemigo
    private enum State
    {
        Idle,
        Attacking
    }

    private State state;
    private EnemyPathing enemyPathing;

    private void Awake()
    {
        enemyPathing = GetComponent<EnemyPathing>();
        state = State.Idle;

        myAnimator = GetComponent<Animator>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        StartCoroutine(IdleRoutine());
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {

            PlayerController player = collision.gameObject.GetComponent<PlayerController>();


            myAnimator.SetTrigger("Attack");
            StartCoroutine(WaitAttackCoroutine(.5f, player));
            

        }
        if (collision.gameObject.tag == "Fireball")
        {
            RedFireball fireball = collision.gameObject.GetComponent<RedFireball>();
            LoseLife(playerDamage);
            if (state == State.Idle)
            {
                state = State.Attacking;
                StopCoroutine(IdleRoutine());
            }
            StartCoroutine(AttackingRoutine());

            fireball.destroyFireball();

        }

    }

    IEnumerator WaitAttackCoroutine(float time, PlayerController player)
    {
        yield return new WaitForSeconds(time);
        player.LoseLife(3);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            PlayerController player = collision.gameObject.GetComponent<PlayerController>();


            StartCoroutine(AttackingRoutine());

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (state == State.Idle)
            {
                state = State.Attacking;
                StopCoroutine(IdleRoutine());
            }
            StartCoroutine(AttackingRoutine());

        }
    }

    private void LoseLife(float damage)
    {

        health -= damage;
        if (health <= 0)
        {
            Destroy(gameObject);
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            if (player != null)
            {
                PlayerController playerController = player.GetComponent<PlayerController>();
                playerController.IncreaseUpgradePoints(15);
            }
        }
    }

    private IEnumerator IdleRoutine()
    {
        while (state == State.Idle)
        {

            yield return new WaitForSeconds(2f);
        }
    }

    private Vector2 GetRoamingPosition()
    {
        return new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
    }

    private IEnumerator AttackingRoutine()
    {
        while (state == State.Attacking)
        {
            Vector3 playerPosition = GetPlayerPosition();
            enemyPathing.MoveTo(playerPosition);

            myAnimator.SetFloat("moveX", playerPosition.x);
            myAnimator.SetFloat("moveY", playerPosition.y);

            AdjustWarriorFacingDirection();

            yield return new WaitForSeconds(.2f);
        }
    }
    
    private void AdjustWarriorFacingDirection()
    {
        Vector3 playerPos = GetPlayerPosition();
        Vector3 warriorScreenPoint = transform.position;

        if (playerPos.x < warriorScreenPoint.x)
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

    
}
