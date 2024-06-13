using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.Requests;
using UnityEngine;
using UnityEngine.UI;

public class CreateBlock : MonoBehaviour
{    [SerializeField]
    private GameObject createPrefab;
    [SerializeField]
    [Tooltip("生成する範囲A")]
    private Transform rangeA;
    [SerializeField]
    [Tooltip("生成する範囲B")]
    private Transform rangeB;
     [SerializeField]
    private GameObject createPrefab2;
    [SerializeField]
    [Tooltip("生成する範囲A")]
    private Transform rangeC;
    [SerializeField]
    [Tooltip("生成する範囲B")]
    private Transform rangeD;
    public Block target;
    public Text scoreText;

    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
      score = 0;
    }

    // Update is called once per frame
    void Update()
    {
    }
   // void OnEnable()
   // {
   //     target.OnDestroyed.AddListener(()=>{
   //        //Debug.Log("targetがDestroyされました");
　//　　　　　 // ここに処理を追加
  //      RandomCreate();
  //      });
  //  }
    public void RandomCreate(){
//        target.OnDestroyed.AddListener(()=>{
   //        //Debug.Log("targetがDestroyされました");
　//　　　　　 // ここに処理を追加
  //      RandomCreate();
        //CDT.countdown = CDT.countdown + 5f;
        score += 1;
        //scoreText.text = score.ToString(); 
        float x = Random.Range(rangeA.position.x, rangeB.position.x);
        // rangeAとrangeBのy座標の範囲内でランダムな数値を作成
        float y = Random.Range(rangeA.position.y, rangeB.position.y);

        Instantiate(createPrefab,new Vector2(x,y),createPrefab.transform.rotation);
    //});
    }
        public void URandomCreate(){
        //CDT.countdown = CDT.countdown + 5f;
        score += 1;
        //scoreText.text = score.ToString(); 
        if(score < 10){
        float x2 = Random.Range(rangeC.position.x, rangeD.position.x);
        // rangeAとrangeBのy座標の範囲内でランダムな数値を作成
        float y2 = Random.Range(rangeC.position.y, rangeD.position.y);

        Instantiate(createPrefab2,new Vector2(x2,y2),createPrefab2.transform.rotation);
        }
    }


}
