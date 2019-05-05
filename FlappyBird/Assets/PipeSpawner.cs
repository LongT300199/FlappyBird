using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour {

	public float spawningInterval = 1;
	private float timer = 0;
	public GameObject pipe;
	public float height;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (timer > spawningInterval) {
			GameObject newPipe = Instantiate(pipe);
			newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
			
			Destroy(newPipe, 15);
			timer = 0;
		}
		timer += Time.deltaTime;
	}
}
