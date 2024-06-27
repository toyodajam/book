using UnityEngine;

public class Player : MonoBehaviour
{
    	private Rigidbody2D myRigidBody;
        public float playerSpeed = 10;
        Transform myTransform;
        float speed = 10f;
    Vector3 MousePos;
    Vector2 player_pos;


    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = this.gameObject.GetComponent<Rigidbody2D>();
        myTransform = transform;

        
    }

    // Update is called once per frame
void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //    MousePos = Input.mousePosition;
        }
        if (Input.GetMouseButton(0))
        {
        //    Vector3 mousePosDiff = Input.mousePosition - MousePos;
            MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //    Vector3 newPos = this.gameObject.transform.position + new Vector3(mousePosDiff.x / Screen.width, 0, mousePosDiff.y / Screen.height) * speed;

        //    this.transform.position = newPos;
            player_pos = this.transform.position;
            MousePos.y = -4;
            MousePos.z = 0;
            this.transform.position = 
            Vector3.MoveTowards(this.transform.position , MousePos , speed * Time.deltaTime);
        }
    }
    void FixedUpdate()
    {
//    Vector2 screen_LeftBottom = Camera.main.ScreenToWorldPoint(Vector3.zero);
// 画面の右上の座標を取得 (右下じゃないので注意)
//Vector2 screen_RightTop = Camera.main.ScreenToWorldPoint(
//    new Vector3(Screen.width, Screen.height, 0));
//        Vector2 player_pos = transform.position;
//       Vector2 force = Vector2.zero;
//       if(Input.GetKey(KeyCode.LeftArrow) && (player_pos.x > screen_LeftBottom.x + 0.5))
//       {
//        force = new Vector2(playerSpeed * -1,0);
//       }
//        if(Input.GetKey(KeyCode.RightArrow) && (player_pos.x < screen_RightTop.x - 0.5))
//       {
//        force = new Vector2(playerSpeed,0);
//       }
//        myRigidBody.MovePosition(myRigidBody.position + force * Time.fixedDeltaTime);
    }
}
