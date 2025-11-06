using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorInteligence : MonoBehaviour
{

    [SerializeField] private float health = 3;

    private Animator myAnimator;
    private SpriteRenderer mySpriteRenderer;

    //Estados del enemigo
    private enum State
    {
        Idle, // caminando
        Attacking // atacando
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

    private void FixedUpdate()
    {
        
    }

    /**
    private void AdjustWarriorFacingDirection()
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

    }*/

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {

            PlayerController player = collision.gameObject.GetComponent<PlayerController>();
            player.LoseLife(1);
        }
        if (collision.gameObject.tag == "Fireball")
        {
            RedFireball fireball = collision.gameObject.GetComponent<RedFireball>();
            LoseLife(1);
            if (state == State.Idle)
            {
                state = State.Attacking;
                StopCoroutine(IdleRoutine());
            }
            StartCoroutine(AttackingRoutine());

            fireball.destroyFireball();

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

    private void LoseLife(int damage)
    {

        health -= damage;
        if (health <= 0)
        {
            Destroy(gameObject);
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            if (player != null)
            {
                PlayerController playerController = player.GetComponent<PlayerController>();
                playerController.AddXP(10);
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
            Vector2 playerPosition = GetPlayerPosition();
            enemyPathing.MoveTo(playerPosition);

            myAnimator.SetFloat("moveX", playerPosition.x);
            myAnimator.SetFloat("moveY", playerPosition.y);

            yield return new WaitForSeconds(.2f);
        }
    }

    private Vector2 GetPlayerPosition()
    {
        return GameObject.FindGameObjectWithTag("Player").transform.position;
    }
}
