using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{

    
     private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("apple"))
        {
            Destroy(col.gameObject);
        }
    }
}
