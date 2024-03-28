using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cronometro : MonoBehaviour
{
	public Text CronometroText;
	private float tempoAtual;

    void Start()
    {
        tempoAtual = 0;
    }


    void Update()
    {

		tempoAtual += Time.deltaTime;
		CronometroText.text = tempoAtual.ToString("F2");   
		
    }
}