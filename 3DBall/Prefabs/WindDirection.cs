 using UnityEngine;
 using System.Collections;
 
 public class WindDirection : MonoBehaviour {
 
     void Start () {
         new WaitForSeconds(1);
         transform.rotation = Random.rotation;
     }
 }
 