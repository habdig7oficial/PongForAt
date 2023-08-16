using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){

    }

    // Update is called once per frame
    void Update()
    {
        Moviment();
    }


    public KeyCode moveUp;
    public KeyCode moveDown;

    public int velocidade = 9;
    public float miny = -163.76F;
    public float maxy = -163.76F;
    public void Moviment(){
        //transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, miny, maxy ));

        if(Input.GetKey(moveUp)){
            transform.Translate(Vector2.up * this.velocidade * Time.deltaTime);
        }

        if(Input.GetKey(moveDown)){
            transform.Translate(Vector2.down * this.velocidade * Time.deltaTime);
        }
    }
}
