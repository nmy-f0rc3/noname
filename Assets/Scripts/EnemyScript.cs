using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public int Health;
    public int points;
    public GameObject EnemyShip;
    public float EnemyVelocity = 0.01f;
    public PlayerScripts Player { get; set; }
    private Vector3 target;
    private Vector3 enemyPosition;

    private MeshRenderer mRenderer;
    private Transform myTransform;

    private void Awake()
    {
        mRenderer = GetComponent<MeshRenderer>();
        myTransform = transform;
    }

    public void Init(float x, float y, float z, Color color, State state, int HP, int Point, PlayerScripts player)
    {
        //var sodomit = Instantiate(EnemyShip, new Vector3(x, y, z), Quaternion.identity);
        Player = player;
        myTransform.position = new Vector3(x, y, z);
        mRenderer.material.SetColor("_Color", color);
        enemyState = state;
        Health = HP;
        points = Point;
    }

    public enum State
    {
        Left,
        Right,
        DownLeft,
        DownRight,
        Fly

    }

    private void OnTriggerEnter(Collider HitScan)
    {
        PlayerScripts player = HitScan.GetComponent<PlayerScripts>();
        if (player != null)
        {
            player.TakeDamage(3);
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int Damage)
    {
        Health -= Damage;
        if (Health <= 0)
        {
            Player.AddPoints(points);
            //GameObject player = GameObject.FindGameObjectsWithTag("Player")[0];
            //player.SendMessage("AddPoints", points);
            Die();
        }

    }

    void Die()
    {
        Debug.LogError("ME DEAD!");
        gameObject.SetActive(false);
    }

    public State enemyState = State.Fly;

    void Start()
    {
        enemyPosition = gameObject.transform.position;
        target = enemyPosition + GetNextTarget(enemyState);
        

    }



    void Update()
    {

        transform.position = Vector3.MoveTowards(transform.position, target, EnemyVelocity*Time.timeScale) ;
        if (Mathf.Approximately((transform.position - target).sqrMagnitude, 0f))
        {
            SwitchState(enemyState);
        }
        if (enemyState == State.Fly)
        {
            EnemyVelocity = 0.035f;
        }
        if (enemyState != State.Fly)
        {
            EnemyVelocity = 0.01f;
        }
    }

    private Vector3 GetNextTarget(State state)
    {
        switch (state)
        {
            case State.Fly: return Vector3.down * 5;
            case State.Left: return Vector3.left;
            case State.Right: return Vector3.right;
            case State.DownLeft: return Vector3.back;
            case State.DownRight: return Vector3.back;
            default: return Vector3.zero;
        }
    }

    private void SwitchState(State state)
    {
        switch (state)
        {
            case State.Fly:
                enemyState = State.Right;
                break;
            case State.Left:
                enemyState = State.DownLeft;
                break;
            case State.Right:
                enemyState = State.DownRight;
                break;
            case State.DownLeft:
                enemyState = State.Right;
                break;
            case State.DownRight:
                enemyState = State.Left;
                break;
        }
        target = transform.position + GetNextTarget(enemyState);
    }
}
