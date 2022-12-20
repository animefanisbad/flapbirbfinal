using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colum : MonoBehaviour
{
   private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.GetComponent<bird>() != null)
        {
            GameController.instance.BirdScored();
        }
    }
}
