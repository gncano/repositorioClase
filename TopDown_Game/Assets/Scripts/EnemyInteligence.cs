using System.Collections;
using UnityEngine;

public class EnemyIntelligence : MonoBehaviour
{

    //Estados del enemigo
    private enum State
    {
        Roaming // caminando
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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.tag == "Slime")
        {
            if (collision.gameObject.tag == "Player")
            {
                
                PlayerController player = collision.gameObject.GetComponent<PlayerController>();
                player.LoseLife(1);
            }
        }
    }
}
