using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Block : MonoBehaviour
{    [SerializeField]
    private GameObject createPrefab;
    
    //[Tooltip("生成する範囲A")]
    //public Transform rangeA;
    
    //[Tooltip("生成する範囲B")]
    //public Transform rangeB;

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
            GM.RandomCreate();
//        float x = Random.Range(rangeA.position.x, rangeB.position.x);
//        // rangeAとrangeBのy座標の範囲内でランダムな数値を作成
//        float y = Random.Range(rangeA.position.y, rangeB.position.y);

//        Instantiate(createPrefab,new Vector2(x,y),createPrefab.transform.rotation);

          // OnDestroy();
        }

    }


}
