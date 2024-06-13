using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class UBlock : MonoBehaviour
{    [SerializeField]
    private GameObject createPrefab2;
    
    [Tooltip("生成する範囲A")]
    public Transform rangeC;
    
    [Tooltip("生成する範囲B")]
    public Transform rangeD;

    public GameManager GM;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //    public UnityEvent OnDestroyed = new UnityEvent();
    //private void OnDestroy(){
    //    //Debug.Log("Destroyed");
    //    OnDestroyed.Invoke();
    //}
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Ball")
        {
            Destroy(this.gameObject);
            //if(SC.score <= 9)
            //{
            GM.URandomCreate();
            //}
//        float x = Random.Range(rangeA.position.x, rangeB.position.x);
//        // rangeAとrangeBのy座標の範囲内でランダムな数値を作成
//        float y = Random.Range(rangeA.position.y, rangeB.position.y);

//        Instantiate(createPrefab,new Vector2(x,y),createPrefab.transform.rotation);

          // OnDestroy();
        }

    }


}
