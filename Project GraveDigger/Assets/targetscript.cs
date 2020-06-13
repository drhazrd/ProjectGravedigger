
using UnityEngine;

public class targetscript : MonoBehaviour
{
    public float health;public Animator stormanim;
    public void Start()
    {
        stormanim = GetComponent<Animator>();
    }
    public void TakeDamage(float amount) { health -= amount;if (health <= 0f) { Die(); } }
    void Die() { stormanim.SetBool("isdead",true);
        //Destroy(gameObject);
    }
}
