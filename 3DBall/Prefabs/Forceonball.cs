 using UnityEngine;
 using System.Collections;
 
 public class Forceonball : MonoBehaviour {
 
     public GameObject windObject;
     Rigidbody rigidbody;
 
     void Start () {
         rigidbody = gameObject.GetComponent<Rigidbody> ();
     }
 
     void FixedUpdate () {
         rigidbody.AddForce (windObject.transform.forward * 10);
     }
 }
 