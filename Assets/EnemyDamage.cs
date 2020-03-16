using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    private int hitNumber;

    void OnCollisionEnter(Collision other)
    {
     	if (other.transform.CompareTag("bullet")){
	    //If the comparision is true, we increase the hit number.
	    hitNumber++;
	}
	if (hitNumber == 3){
	    Destroy(gameObject);
	}   
    }
}
