using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class responder : MonoBehaviour {

	private int idTema;

	public Text pergunta;
	public Text  respostaA;
	public Text  respostaB;
	public Text  respostaC;
	public Text  respostaD;
	public Text infoRespostas;

	public string[] perguntas;		// armazena todas as perguntas 
	public string[] alternativaA;	// armazena todas as alternativas A
	public string[] alternativaB;	// armazena todas as alternativas B
	public string[] alternativaC;	// armazena todas as alternativas C
	public string[] alternativaD;	// armazena todas as alternativas D
	public string[] corretas;		// armazena todas as alternativas corretas	

	private int idePergunta;

	private float acertos;
	private float questoes;
	private float media;
	private int notaFinal;

	// Use this for initialization
	void Start () {

		idTema = PlayerPrefs.GetInt ("idTema");

		idePergunta = 0;
		questoes = perguntas.Length;

		pergunta.text = perguntas [idePergunta];
		respostaA.text = alternativaA[idePergunta];
		respostaB.text = alternativaB[idePergunta];
		respostaC.text = alternativaC[idePergunta];
		respostaD.text = alternativaD[idePergunta];

		infoRespostas.text = "Respondendo "+ (idePergunta + 1).ToString() + " de "+questoes.ToString() +" perguntas.";
		
	}
	
	public void resposta(string alternativa)
	{
		if(alternativa == "A")
		{
			
			if(alternativaA[idePergunta] == corretas [idePergunta])
			{	
				acertos += 1; 
			}
	}

		else if(alternativa == "B")
		{
			if(alternativaB[idePergunta] == corretas [idePergunta])
			{	
				acertos += 1; 
			}
		
		}

		else if(alternativa == "C")

		{
			if(alternativaC[idePergunta] == corretas [idePergunta])
			{	
				acertos += 1; 
			}
		}
		else if(alternativa == "D")

		{
			if(alternativaD[idePergunta] == corretas [idePergunta])
			{	
				acertos += 1; 
			}
		}

		proximaPergunta ();

	}

	void proximaPergunta()
	{
		idePergunta += 1;

		if (idePergunta <= (questoes-1))
		{

		pergunta.text = perguntas [idePergunta];
		respostaA.text = alternativaA[idePergunta];
		respostaB.text = alternativaB[idePergunta];
		respostaC.text = alternativaC[idePergunta];
		respostaD.text = alternativaD[idePergunta];

		infoRespostas.text = "Respondendo "+ (idePergunta + 1).ToString() + " de "+questoes.ToString() +" perguntas.";

	}

		else
		{
			// oque fazer se terminar as perguntas

			media = 10 * (acertos / questoes); // calcula a media com base no percentual do acerto
			notaFinal = Mathf.RoundToInt (media); // arredonda a nota para o próximo inteiro seguindo a regra da matematica
			if (notaFinal > PlayerPrefs.GetInt ("notaFinal"+idTema.ToString()))
			{
				PlayerPrefs.SetInt ("notaFinal" + idTema.ToString (), notaFinal);
				PlayerPrefs.GetInt ("acertos"+idTema.ToString(),(int) acertos);

			}
			PlayerPrefs.SetInt ("notaFinalTemp" + idTema.ToString (), notaFinal);
			PlayerPrefs.GetInt ("acertosTemp"+idTema.ToString(),(int) acertos);

			Application.LoadLevel ("notaFinal");

			}
	}
}