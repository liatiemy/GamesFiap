using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverFundoScript : MonoBehaviour {

	public float velocidade;
	public float posicaoInicial, posicaoFinal;

	// Update is called once per frame
	void Update () {

		//verifica se atingiu o limite da camera e reposiciona para um novo ciclo
		if (transform.position.x <= posicaoFinal) {
			transform.position = new Vector2 (posicaoInicial, transform.position.y);
		}

		//move o fundo para a esquerda
		transform.Translate (Vector2.left * velocidade * Time.deltaTime);
	}
}
