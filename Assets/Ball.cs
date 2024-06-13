using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class BallScrypt : MonoBehaviour
{
	public Rigidbody2D myRigidBody;
	public float speedX = 10;
	public float speedY = 10;
    public float speed;

    public float MaxSpeed;
    public GameManager myManager;
    Transform myTransform;

    public GameObject GameStartUI;
    public float StartTime;
    public CountDownTimer CD;
    public CreateBlock CB;
    UnityEngine.Vector2 vec;





        // 画面の左下の座標を取得 (左上じゃないので注意)


    // Start is called before the first frame update
    void Start()
    {
    myTransform = transform;

    }

    // Update is called once per frame
    void Update()
    {
    UnityEngine.Vector2 screen_LeftBottom = Camera.main.ScreenToWorldPoint(UnityEngine.Vector3.zero);
// 画面の右上の座標を取得 (右下じゃないので注意)
    UnityEngine.Vector2 screen_RightTop = Camera.main.ScreenToWorldPoint(
    new UnityEngine.Vector3(Screen.width, Screen.height, 0));

        // 現在のプレイヤーの移動情報(向きと強さ)
vec = myRigidBody.velocity;
// 現在のプレイヤーの位置座標
UnityEngine.Vector2 player_pos = transform.position;
// 画面左端に達した時、プレイヤーが左方向に動いていたら、右方向の力に反転する
if ((player_pos.x < screen_LeftBottom.x + 0.25) && (vec.x < 0))
    vec.x *= -1;
// 画面右端に達した時、プレイヤーが右方向に動いていたら、左方向の力に反転する
if ((player_pos.x > screen_RightTop.x - 0.25) && (vec.x > 0))
    vec.x *= -1;
// 画面下端に達したときしぬ
if ((player_pos.y < screen_LeftBottom.y) && (vec.y < 0)) {
    Destroy(this.gameObject);
    myManager.GameOver();
}
// 更新
myRigidBody.velocity = vec;
    }

    public void Accel(float accel){
        float speed = myRigidBody.velocity.magnitude + accel;
        UnityEngine.Vector2 direction = myRigidBody.velocity.normalized;
        myRigidBody.velocity = direction * speed;
    }

        private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Finish")
        {
            Destroy(this.gameObject);
            myManager.GameOver();
        }

         // プレイヤーに当たったときに、跳ね返る方向を変える
        if (collision.gameObject.CompareTag("Player"))
        {
            // プレイヤーの位置を取得
            UnityEngine.Vector2 playerPos = collision.transform.position;
            // ボールの位置を取得
            UnityEngine.Vector2 ballPos = myTransform.position;
            // プレイヤーから見たボールの方向を計算
            UnityEngine.Vector2 direction = (ballPos - playerPos).normalized;
            // 現在の速さを取得
            float speed = myRigidBody.velocity.magnitude;
            // 速度を変更
            myRigidBody.velocity = direction * speed;

            //if (speed < MaxSpeed)
            //{
            //    speed = speed + accel;
            //    myRigidBody.velocity = direction * speed;
            //}

        }
        //壁反射角修正
        UnityEngine.Vector2 vec = myRigidBody.velocity;
        vec.Normalize();
        if (0.25f > Mathf.Abs(vec.y))
        {
            if (0.0f <= (vec.x * vec.y))
                vec = UnityEngine.Quaternion.Euler(0.0f, 0.0f, 15.0f) * vec;
            else
                vec = UnityEngine.Quaternion.Euler(0.0f, 0.0f, -15.0f) * vec;
        }
        speed = myRigidBody.velocity.magnitude;
        vec *= speed;
        myRigidBody.velocity = vec;
    }
    public void GameStart()
        {
        //CB.score = 0;//後で消す        
        
        myRigidBody = this.gameObject.GetComponent<Rigidbody2D>();

    	UnityEngine.Vector2 force = new UnityEngine.Vector2(speedX, speedY);

    	myRigidBody.AddForce(force);

        GameStartUI.SetActive(false);  

        //StartTime = Time.deltaTime;
        CD.enabled = true;

        }
}

