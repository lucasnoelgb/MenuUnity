# Menu e Creditos
Para criar o menu e os adicionamos o elemento canvas e deixando em resolução FU HD ai foi adicionado o painel mais uma imagem e em seguida criamos um botão e um gameobject vazio para armazenar os scripts para a troca de cena o processo foi repetido nos Creditos porém retirando um um buttom e adicionando um texto.
![image](https://github.com/lucasnoelgb/MenuUnity/assets/129121307/6c7519e3-a24c-456d-9a5b-0e6d6966b125)
![image](https://github.com/lucasnoelgb/MenuUnity/assets/129121307/339e593d-7218-4a60-b008-2d05b8b4f652)
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

