using UnityEngine;
using System.Collections;

public class EndAnim : MonoBehaviour {

    Transform orig;
    Transform t;
    int cycles = 0;

    void Start(){
        t = transform;
        orig.position = new Vector3(t.position.x,t.position.y,t.position.z);
    } 

    void LateUpdate () 
    {
        
        t.position = new Vector3 (t.position.x + 5,t.position.y,t.position.z); 
        cycles++; 
        if (cycles > 480) t.position = new Vector3(orig.position.x,orig.position.y,orig.position.z);
    }
}