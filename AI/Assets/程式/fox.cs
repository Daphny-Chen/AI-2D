using UnityEngine;      //引用UnityAPTT-API倉庫功能、工具

public class fox : MonoBehaviour    //類別 類別名稱
{

    public int speed = 50;
    public float jump = 2.5f;
    public string foxName = "狐狸";
    public bool pass = false;
    private Rigidbody2D r2d;
    public bool isGround;
    //成員:欄位、屬性、方法、事件

    //事件:在特定時間點會已指定頻率執行的方法
    //開始事件:遊戲開始時執行一次
    private void Start()
    {
        r2d = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D)) Turn(0);
        if (Input.GetKeyDown(KeyCode.A)) Turn(180);
    }

    private void FixedUpdate()
    {
        Walk();
        Jump();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGround = true;
        Debug.Log("碰到" + collision.gameObject);   
    }

    /// <summary>
    /// 走路
    /// </summary>
    private void Walk()
    {
        r2d.AddForce(new Vector2(speed * Input.GetAxis("Horizontal"),0));
    }


    /// <summary>
    /// 跳躍
    /// </summary>
    private void Jump()
    {
        if (Input.GetKey(KeyCode.Space)&&isGround==true)
        {
        r2d.AddForce(new Vector2(0,jump));
            isGround = false;
        }
    }



    /// <summary>
    /// 旋轉
    /// </summary>
    /// <param name="direction">向左180，向右0</param>

    private void Turn(int direction)
    {
        transform.eulerAngles = new Vector3(0, direction, 0);
    }
}
