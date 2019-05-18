using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
       // GameObject path = GameObject.Find("/Environment/Ground (10)");
       // path.GetComponent<Renderer>().material.color = Color.red;
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.color = Color.gray;
    }
	
	// Update is called once per frame
	void Update () {
        
       // Color[] colors = {Color.black, Color.white};
       // System.Random random = new System.Random();
       // Renderer renderer = GetComponent<Renderer>();
       // int randomNumber = random.Next(0, 1);
       // renderer.material.color = colors[randomNumber];

       
    }
}
