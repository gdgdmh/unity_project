﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronThornsBall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// 当たり判定(Enter)
    /// </summary>
    /// <param name="other">ヒットした対象</param>
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter(IronThornsBall) tag(" + other.tag + ") name(" + other.name + ")");
        if (other.tag == "player")
        {
            // プレイヤーと当たったら削除
            OnDestroyIronThornsBall();
        }
    }

    /// <summary>
    /// 障害物の削除処理
    /// </summary>
    private void OnDestroyIronThornsBall()
    {
        // 障害物のゲームオブジェクト削除
        DestoryIronThornsBall();
    }

    /// <summary>
    /// 障害物のゲームオブジェクトの削除
    /// </summary>
    private void DestoryIronThornsBall()
    {
        Destroy(this.gameObject);
    }
}
