using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour {

    public static int deathPoint = 0;
    public static int goodPoint = 0;
    public static int normalPoint = 0;


	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(this);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
