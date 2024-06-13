using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading;

public class GameManager : MonoBehaviour
{

    public GameObject GameOverUI;
    public GameObject GameClearUI;
    public GameObject GameStartUI;
    public BallScrypt Ball;

    [SerializeField]
    private GameObject createPrefab;
    [SerializeField]
    [Tooltip("生成する範囲A")]
    private Transform rangeA;
    [SerializeField]
    [Tooltip("生成する範囲B")]
    private Transform rangeB;

    public GameObject Block;
    private Block B;

    [SerializeField]
    private GameObject createPrefab2;
    [SerializeField]
    [Tooltip("生成する範囲C")]
    private Transform rangeC;
    [SerializeField]
    [Tooltip("生成する範囲D")]
    private Transform rangeD;

    public GameObject UBlock;
    public UBlock uB;

    //public Block target;
    public Text scoreText;
    public CountDownTimer CDT;

    public int score = 0;
    public float accel;

    int number;

    // Start is called before the first frame update
    void Start()
    {
        //CD.enabled = true;
        Time.timeScale = 1;
        //score = 0;//後で消す
        float x = Random.Range(rangeA.position.x, rangeB.position.x);
        // rangeAとrangeBのy座標の範囲内でランダムな数値を作成
        float y = Random.Range(rangeA.position.y, rangeB.position.y);

        Block = Instantiate(createPrefab,new Vector2(x,y),createPrefab.transform.rotation);
        B = Block.GetComponent<Block>();
        B.GM = this;
    
        float x2 = Random.Range(rangeC.position.x, rangeD.position.x);
        // rangeAとrangeBのy座標の範囲内でランダムな数値を作成
        float y2 = Random.Range(rangeC.position.y, rangeD.position.y);

        UBlock = Instantiate(createPrefab2,new Vector2(x2,y2),createPrefab2.transform.rotation);
        uB = UBlock.GetComponent<UBlock>();
        uB.GM = this;
   
    }

    // Update is called once per frame
    void Update()
    {
        //if (DestroyAllBlocks())
        //{
        //    //ゲームクリア時
        //    Debug.Log("ゲームクリア");
        //    GameClearUI.SetActive(true);
        //    Destroy(Ball.gameObject);
       // float x = Random.Range(rangeA.position.x, rangeB.position.x);
        // rangeAとrangeBのy座標の範囲内でランダムな数値を作成
        //float y = Random.Range(rangeA.position.y, rangeB.position.y);

        //Instantiate(createPrefab,new Vector2(x,y),createPrefab.transform.rotation); 

//
        //}
    }
    public void RandomCreate(){
//        target.OnDestroyed.AddListener(()=>{
   //        //Debug.Log("targetがDestroyされました");
　//　　　　　 // ここに処理を追加
  //      RandomCreate();
        CDT.countdown = CDT.countdown + 5f;
        score += 1;
        if(score % 10 == 0){
            Ball.Accel(accel);
        }
        //scoreText.text = score.ToString(); 
        float x = Random.Range(rangeA.position.x, rangeB.position.x);
        // rangeAとrangeBのy座標の範囲内でランダムな数値を作成
        float y = Random.Range(rangeA.position.y, rangeB.position.y);

        Block = Instantiate(createPrefab,new Vector2(x,y),createPrefab.transform.rotation);
        
        B = Block.GetComponent<Block>();
        B.GM = this;


    //});
    }
        public void URandomCreate(){
        CDT.countdown = CDT.countdown + 5f;
        score += 1;
        //scoreText.text = score.ToString();
        if(score % 10 == 0){
            Ball.Accel(accel);
        }
        if(score < 10){
        float x2 = Random.Range(rangeC.position.x, rangeD.position.x);
        // rangeAとrangeBのy座標の範囲内でランダムな数値を作成
        float y2 = Random.Range(rangeC.position.y, rangeD.position.y);

        UBlock = Instantiate(createPrefab2,new Vector2(x2,y2),createPrefab2.transform.rotation);
        
        uB = UBlock.GetComponent<UBlock>();
        uB.GM = this;
        
        }


    }

    public void GameOver(){
        GameOverUI.SetActive(true);
        Time.timeScale = 0;
    }

    public void GameRetry()
    {
        SceneManager.LoadScene("Target2");
        Ball.GameStart();
    }
    public void ReturnTitle()
    {
        SceneManager.LoadScene("Title");
    }

}
