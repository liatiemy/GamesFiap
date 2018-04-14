using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubInimigoScript : MonoBehaviour {

    public GameObject alvo;
    public float velocidade;

	void Start () {
        // Atribui o alvo a ser perseguido
        alvo = GameObject.FindGameObjectWithTag("Player");         
	}
		
	void Update () {
        // Persegue o alvo
        transform.position = Vector2.Lerp(
            transform.position, alvo.transform.position, 
            velocidade * Time.deltaTime
            ); 
	}

	void OnTriggerEnter2D(Collider2D c){
		print ("atingi o inimigo");
		//como o peixinho eh trigger nao precisa colocar c.gameobject.tag
		if (c.tag == "projetil") {
			Destroy(c.gameObject);
		}
	}
}
