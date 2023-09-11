using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float velocidad;
    public float salto;
    private Rigidbody fisicas;
    float velocity;
    // Start is called before the first frame update
    void Start()
    {
        fisicas = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update(){
    var horizontal = Input.GetAxis("Horizontal");
    var vertical = Input.GetAxis("Vertical");
    
    var movimiento = new Vector3(horizontal, 0, vertical).normalized
     * (Time.deltaTime * velocidad);
    transform.Translate(movimiento);

    if (Input.GetKey(KeyCode.Space)) {
        fisicas.AddForce(new Vector3(0, salto, 0));
    }
    
    }
}
