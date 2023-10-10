using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class notaFinal : MonoBehaviour {


	private int idTema;

	public Text txtNota;
	public Text txtInfoTema;
	public Text textInfoTema2;
	
	public GameObject estrela1;
	public GameObject estrela2;
	public GameObject estrela3;
	public GameObject estrela4;
	public GameObject estrela5;

	private int notaF;
	private int acertos;


	// Use this for initialization
	void Start () {

		idTema = PlayerPrefs.GetInt ("idTema");

		estrela1.SetActive (false);
		estrela2.SetActive (false);
		estrela3.SetActive (false);
		estrela4.SetActive (false);
		estrela5.SetActive (false);


		notaF = PlayerPrefs.GetInt ("notaFinalTemp"+idTema.ToString ());
		acertos =  PlayerPrefs.GetInt ("acertosTemp"+idTema.ToString ());

		txtNota.text = notaF.ToString();
		txtInfoTema.text = acertos.ToString();

		if (notaF == 10)
		{
			estrela1.SetActive (true);
			estrela2.SetActive (true);
			estrela3.SetActive (true);
			estrela4.SetActive (true);
			estrela5.SetActive (true);
			txtInfoTema.text = "Mestre!!!";
			textInfoTema2.text = "Você atingiu o limite da sua insanidade";

		}
		else if (notaF >= 8)
		{

			estrela1.SetActive (true);
			estrela2.SetActive (true);
			estrela3.SetActive (true);
			estrela4.SetActive (true);
			estrela5.SetActive (false);

			txtInfoTema.text = "Você acertou quatro perguntas e ganhou 8 pontos e 4 estrelas.";
			textInfoTema2.text = "Quase lá,Mantenha calma,eu sei que você consegue!!";

		}

		else if (notaF >= 6)
		{
			estrela1.SetActive (true);
			estrela2.SetActive (true);
			estrela3.SetActive (true);
			estrela4.SetActive (false);
			estrela5.SetActive (false);

			txtInfoTema.text = "Você acertou três perguntas e ganhou 6 pontos e três estrelas.";
			textInfoTema2.text = "É nesse momento que o conhecimento torna-se mais importante que a imaginação!";
		}
		else if (notaF >= 4)
		{
			estrela1.SetActive (true);
			estrela2.SetActive (true);
			estrela3.SetActive (false);
			estrela4.SetActive (false);
			estrela5.SetActive (false);

			txtInfoTema.text = "Você acertou duas perguntas e ganhou 4 pontos e duas estrelas.";
			textInfoTema2.text = "Porquê a pressa? Relaxe,respire fundo e tente novamente ou desista pra sempre!";
		}
			
	else if (notaF >= 2)
	{
		estrela1.SetActive (true);
		estrela2.SetActive (false);
		estrela3.SetActive (false);
		estrela4.SetActive (false);
		estrela5.SetActive (false);

		txtInfoTema.text = "Você acertou apenas uma pergunta e ganhou 2 pontos e uma estrela.";
		textInfoTema2.text = "Porquê a pressa? Relaxe,respire fundo e tente novamente ou desista pra sempre!";
	}

	}
	public void jogarNovamente()
	{
		Application.LoadLevel("T"+idTema.ToString());
	}
	
	// Update is called once per frame
	void Update () {

		
	}
}
