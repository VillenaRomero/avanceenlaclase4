using UnityEngine;

public class ejercicio1 : MonoBehaviour
{
    private int life = 100;
    private bool isAlives = true;

    public int Life => life;
    public bool IsAlives => isAlives;

    public ejercicio1(int life, bool isAlives)
    {
        this.life = life;
        this.isAlives = isAlives;
    }

    public void SetLife(int _life)
    {
        life = _life;
    }
    public void GetDamage(int damage)
    {
        life -= damage;
        if (life <= 0) {
            print("El jugador a muerto ");
            isAlives = false;
        }
        print("El jugador a tomado : " + damage + " de daño.");
    }
   
}
