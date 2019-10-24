﻿using UnityEngine;      //引用UnityAPTT-API倉庫功能、工具

public class fox : MonoBehaviour    //類別 類別名稱
{

    public int speed = 50;
    public float jump = 2.5f;
    public string foxName = "狐狸";
    public bool pass = false;
    private Rigidbody2D r2d;
    //成員:欄位、屬性、方法、事件

    //事件:在特定時間點會已指定頻率執行的方法
    //開始事件:遊戲開始時執行一次
    private void Start()
    {
        r2d = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D)) transform.eulerAngles = new Vector3(0, 0, 0);
        if (Input.GetKeyDown(KeyCode.A)) transform.eulerAngles = new Vector3(0, 180, 0);
    }

    private void FixedUpdate()
    {
        r2d.AddForce(new Vector2(speed * Input.GetAxis("Horizontal"),0));
    }




}
