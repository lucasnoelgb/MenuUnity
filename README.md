# Dupla
Lucas Noel<br>
Lucas Carvalho

# Menu e Creditos


Para criar o menu e os adicionamos o elemento canvas e deixando em resolução FU HD ai foi adicionado o painel mais uma imagem e em seguida criamos um botão e um gameobject vazio para armazenar os scripts para a troca de cena o processo foi repetido nos Creditos porém retirando um um buttom e adicionando um texto.

![image](https://github.com/lucasnoelgb/MenuUnity/assets/129121307/61ec3de3-0b6f-4b5a-81ae-ff28dbfd57d3)
![image](https://github.com/lucasnoelgb/MenuUnity/assets/129121307/2f010ad6-18ca-45e3-a768-f3acd289e9cb)


 - O codigo abaixo foi ultilizado para a troca de cena juntamente com a função "Onclick" do Buttom.

        using System.Collections;
        using System.Collections.Generic;
        using UnityEngine;
        using UnityEngine.SceneManagement;

          public class LoadGame : MonoBehaviour
          {


          public void CarregarJogao()
            {
          SceneManager.LoadScene("Jogao");
            }
  
          public void Sair()
                {
              Application.Quit();
                }
          } 
- Para a troca de Cena foi adicionado alguns elementos em um dos colisores criados anteriormente fazendo que o codigo fica-se desta forma

        using System.Collections;
        using System.Collections.Generic;
        using UnityEngine;
        using UnityEngine.SceneManagement;


          public class ObjetoKinematic: MonoBehaviour

            {
          private void OnTriggerEnter(Collider other)
              {

          if (other.CompareTag("quadrado"))
                {
            AtivarEventoPegar();
            SceneManager.LoadScene("Creditos");

                 }
                }

    
                  private void AtivarEventoPegar()
                      {      


                    Debug.Log("Objeto Pego! ");
                    gameObject.SetActive(false);
                      }

              }
  
  # Hub Dinamico
- Para o hub dinamico foi feito um timer para a contagem em quanto tempo o jogador demoraria para aceitar o "lixo".
   
![image](https://github.com/lucasnoelgb/MenuUnity/assets/129121307/ad11e1cd-f814-4444-9ebf-95723a2cb4b6)
- Codigo usado para o cronômetro

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
  # GamePlay


https://github.com/lucasnoelgb/MenuUnity/assets/129121307/ea446c2b-4276-4e44-a117-cfa9a75db509


  

