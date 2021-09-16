using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour{

    public int puntosGanados = 5;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        //this.puntosGanados += puntosGanados;
        Debug.Log(this.puntosGanados += puntosGanados);
        Destroy(gameObject);
    }
}
