using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map1UI : MonoBehaviour {
    public static int deathPoint = 0;
    public static int goodPoint = 0;
    public static int normalPoint = 0;

    // Use this for initialization
    void Start () {
        deathPoint = cliAdireUI.deathPoint + Point.deathPoint;
        normalPoint = cliAdireUI.normalPoint + Point.normalPoint;
        goodPoint = cliAdireUI.goodPoint + Point.goodPoint;
        Debug.Log("map1 死神ポイント：" + deathPoint);
        Debug.Log("map1 goodポイント：" + goodPoint);
        Debug.Log("map1 normalポイント：" + normalPoint);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
