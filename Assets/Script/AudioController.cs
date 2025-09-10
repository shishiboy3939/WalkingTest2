using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public GameObject bananaObject; // バナナオブジェクトを入れる変数の宣言
    private AudioSource bananaAudioSource; // バナナオブジェクトについているオーディオソースを入れる変数の宣言
    public float detectionRadius = 5f; // サウンドファイルの再生がトリガーされるFPSControllerオブジェクトとバナナオブジェクトの距離を宣言
    private bool hasPlayed = false; // 再生フラグ（現在のサウンド再生状態）を入れる変数の宣言。初期状態はfalse（停止）。

    void Start()
    {
		// バナナオブジェクトについているオーディオソースをみつける
        bananaAudioSource = bananaObject.GetComponent<AudioSource>();
    }

    void Update()
    {
        // FPSControllerオブジェクトとバナナオブジェクトの距離をはかる
        float distance = Vector3.Distance(transform.position, bananaObject.transform.position);

        if (!hasPlayed) // まだ再生していない場合
        {
            // もしも距離がトリガー距離より小さければ、
            if (distance <= detectionRadius)
            {
                // 再生！
                bananaAudioSource.Play();
                hasPlayed = true; // 再生フラグを再設定
            }
        }
        else if (hasPlayed)
        {
                // もしも距離がトリガー距離より大きければ、
                if (distance >= detectionRadius)
                {
                        // 停止！
                        bananaAudioSource.Stop();
        hasPlayed = false; // 再生フラグを再設定
                }
        }
    }
}