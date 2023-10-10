using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class tempo : MonoBehaviour {

	public Text temaContagem;

	public float contagem = 30.0f;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void  Update () {

		if (contagem > 0.0f) {
			contagem -= Time.deltaTime;
			temaContagem.text = contagem.ToString();

		}

		else {
	
			SceneManager.LoadScene ("Temas");
			}
		
	}
}
