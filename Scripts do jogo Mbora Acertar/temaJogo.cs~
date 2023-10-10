using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class temaJogo : MonoBehaviour {

	public Button 		btnPlay;

	public Text			txtNomeTema;

	public GameObject 	infoTema;
	public Text 		textInfoTema;

	public GameObject esrela1;
	public GameObject esrela2;
	public GameObject esrela3;

	public string[] 	nomeTema;

	public int 			numeroQuestoes;


	private int 		idTema;




	// Use this for initialization
	void Start () {

		idTema = 0;
		txtNomeTema.text = nomeTema [idTema];


		infoTema.SetActive (false);
		esrela1.SetActive (false);
		esrela2.SetActive (false);
		esrela3.SetActive (false);

		btnPlay.interactable = false;
	}

	public void selecioneTema(int i)
	{
		idTema = i;
		PlayerPrefs.SetInt ("idTema", idTema);
		txtNomeTema.text = nomeTema [idTema];
		int notaFinal = PlayerPrefs.GetInt ("notaFinal"+idTema.ToString ());
		int acertos = PlayerPrefs.GetInt ("acertos"+idTema.ToString ());

	




		infoTema.SetActive (true);
		btnPlay.interactable = true;
	}

	public void jogar()

	{

		Application.LoadLevel("T"+idTema.ToString());

	

	}

}
