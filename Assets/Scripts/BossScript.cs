using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{
    public int Health;
    public int points;
    public float EnemyVelocity;

    private Vector3 target;
    private Vector3 enemyPosition;

    public PlayerScripts Player { get; set; }

    public enum State
    {
        Left,
        Right
    }

    public void TakeDamage(int Damage)
    {
        Health -= Damage;
        if (Health == 0)
        {
            Player.AddPoints(points);
            //GameObject player = GameObject.FindGameObjectsWithTag("Player")[0];
            //player.SendMessage("addPoints", points);
            Die();
        }

    }

    void Die()
    {
        Destroy(gameObject);
    }

    public State enemyState = State.Right;

    void Start()
    {
        enemyPosition = gameObject.transform.position;
        target = enemyPosition + GetNextTarget(enemyState);

        

    }

    

    void Update()
    {

        transform.position = Vector3.MoveTowards(transform.position, target, EnemyVelocity * Time.timeScale);
        if (Mathf.Approximately((transform.position - target).sqrMagnitude, 0f))
        {
            SwitchState(enemyState);
        }
    }

    private Vector3 GetNextTarget(State state)
    {
        switch (state)
        {
            case State.Left: return Vector3.left*6;
            case State.Right: return Vector3.right*6;
            default: return Vector3.zero;
        }
    }

    private void SwitchState(State state)
    {
        switch (state)
        {
            case State.Left:
                enemyState = State.Right;
                break;
            case State.Right:
                enemyState = State.Left;
                break;
        }
        target = transform.position + GetNextTarget(enemyState);
    }
}
