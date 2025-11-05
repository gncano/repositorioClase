using System.Collections;
using UnityEngine;

public class EnemyIntelligence : MonoBehaviour
{

    [SerializeField] private float health = 3;

    //Estados del enemigo
    private enum State
    {
        Roaming, // caminando
        Attacking // atacando
    }

    private State state;
    private EnemyPathing enemyPathing;

    private void Awake()
    {
        enemyPathing = GetComponent<EnemyPathing>();
        state = State.Roaming;
    }

    private void Start()
    {
        StartCoroutine(RoamingRoutine());
    }




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
            if (state == State.Roaming)
            {
                state = State.Attacking;
                StopCoroutine(RoamingRoutine());
            }
            StartCoroutine(AttackingRoutine());

            fireball.destroyFireball();

        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (state == State.Roaming)
            {
                state = State.Attacking;
                StopCoroutine(RoamingRoutine());
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

    private IEnumerator RoamingRoutine()
    {
        while (state == State.Roaming)
        {
            Vector2 roamPosition = GetRoamingPosition();
            enemyPathing.MoveTo(roamPosition);
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
            yield return new WaitForSeconds(.2f);
        }
    }

    private Vector2 GetPlayerPosition()
    {
        return GameObject.FindGameObjectWithTag("Player").transform.position;
    }
}
