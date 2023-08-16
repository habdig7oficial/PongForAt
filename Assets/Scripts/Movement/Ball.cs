using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    public float velocidade;
    public Rigidbody2D Ball;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ball.velocity = new Vector2(velocidade, velocidade) * Time.deltaTime;
    }
}
