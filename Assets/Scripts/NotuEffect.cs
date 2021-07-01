using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class NotuEffect : MonoBehaviour
{
    // 子要素を管理するリスト
    List<GameObject> myParts = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        // 自分の子要素をテェック
        foreach(Transform child in gameObject.transform)
        {
            // ノーツにRigidbodyを追加してKinematicにしておく
            child.gameObject.AddComponent<Rigidbody>();
            child.gameObject.GetComponent<Rigidbody>().isKinematic = true;

            // 子要素リストにパーツの追加
            myParts.Add(child.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Explode()
    {
        foreach(GameObject obj in myParts)
        {
            var random = new System.Random();
            var min = -3;
            var max = 3;

            //　飛ぶパワーと回転をランダムに設定
            Vector3 forcePower = new Vector3(random.Next(min, max), random.Next(0, max), random.Next(min, max));
            obj.GetComponent<Rigidbody>().isKinematic = false;
            obj.GetComponent<Rigidbody>().AddForce(forcePower, ForceMode.Impulse);
            obj.GetComponent<Rigidbody>().AddTorque(forcePower, ForceMode.Impulse);
            Invoke("Destroynotu", 2f);
        }
    }

    void Destroynotu()
    {
        Destroy(this.gameObject);
    }
}
