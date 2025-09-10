using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheeseCollision : MonoBehaviour
{
    // CheeseMsgオブジェクトの参照を保持するための変数
    public GameObject cheeseMsg;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cheese"))
        {
            // Cheeseオブジェクトにぶつかった場合の処理
            cheeseMsg.SetActive(true); // CheeseMsgの表示をオンにする
            Destroy(other.gameObject); // Cheeseオブジェクトを削除する
        }
    }
}