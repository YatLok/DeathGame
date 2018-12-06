using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class load : MonoBehaviour {

    public static int a = 200;

    public static int getA(){
        return a;
    }


    // Use this for initialization
    void Start () {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
