using Unity.VisualScripting;
using UnityEngine;

public class GameMnager : MonoBehaviour
{
    private ejercicio1 jugador;


    private void Start()
    {
        Debug.Log("----");
        jugador = new(200, true);


        // jugador.SetLife(40);
        Quitlife();
    }
    /*private void Start()
    {
        Debug.Log("----");
        jugador = new(200, true);


        // jugador.SetLife(40);
        //Quitlife();
    }*/
    /*void Start()
    {
        
      
    }*/

    /* public bool GetIsAlive()
     {
         return jugador.IsAlive;
     }
     bool IsAlive*/
     public void Quitlife() {
          
          while (jugador.IsAlives){

              jugador.GetDamage(10);
          }
      }
}
