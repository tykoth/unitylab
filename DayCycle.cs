using UnityEngine;
using System.Collections;

// Rotaciona um directional light baseado em tempo.
public class DayCycle : MonoBehaviour {

	// Objeto de luz. 
	public Light directionalLight;
	public float startingRotation = 0.0f; // <- temp
	public float speed = 0.1f;
	
	private Vector3 lightRotation;
	// Use this for initialization
	void Start () {
		lightRotation = new Vector3(0,0,0);
		lightRotation.x = startingRotation;
	}
	
	// Update is called once per frame
	void aaaaa () {
	
	}
	
	void FixedUpdate(){
		lightRotation.x+=((1 * Time.timeScale) * speed);
		directionalLight.transform.rotation = Quaternion.Euler(lightRotation);
	}
}
