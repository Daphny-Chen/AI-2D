using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frog : MonoBehaviour {




    [Header("對話")]
    public string SayStart = "  ";
    public string SayNotComplete = "  ";
    public string SayComplete = "  ";
    [Header("對話速度")]
    public float Speed = 1.5f;
    [Header("任務相關")]
    public bool Complete = false;
    public int CountPlayer = 0;
    public int CountFinish = 10;

    // Use this for initialization
    void Start () {
		


	}
	
	// Update is called once per frame
	void Update () {
		

	}
}
