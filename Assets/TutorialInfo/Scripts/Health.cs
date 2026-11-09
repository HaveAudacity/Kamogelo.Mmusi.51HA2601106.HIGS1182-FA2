using UnityEngine;

public class Health : MonoBehaviour
{
    public int health = 100;
    public int takeDamage = 10;
    
    void Start ()
    {
        TakeDamage(takeDamage);
    }
    void Update()
    {
        
    }
    void TakeDamage(int damage)
    {
       Debug.Log("Damage received: " + damage);
        health = health - damage;

        if (health <= 0)
        {
            Debug.Log("Dead");
        }
    }
     
}
