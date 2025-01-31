using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionCible : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision){
        print(collision.gameObject.name + " : " + collision.gameObject.tag);
        if(collision.gameObject.CompareTag("cible A")){
            Destroy(collision.gameObject);
        }
    }
}
