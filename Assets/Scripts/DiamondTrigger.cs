using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    
    private float diamond = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.transform.CompareTag("Diamond"))
        {
            PlayerMovement.numberOfDiamonds++;
            Destroy(other.gameObject);
        }    
    }
}
