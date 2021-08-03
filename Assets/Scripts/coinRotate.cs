using UnityEngine;
using System.Collections;
public class coinRotate : MonoBehaviour {
    public int rotateSpeed;
void Update () {
//this.transform.Rotate(new Vector3(0,1,0),0.1f);
transform.Rotate(0,rotateSpeed,0,Space.World);
 }
 } 
