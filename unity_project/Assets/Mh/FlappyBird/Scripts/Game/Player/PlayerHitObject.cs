using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mh.Flappybird
{
    public class PlayerHitObject : Mhl.Action.Hit.IHitObjectEvent
    {
        private GameObject player;

        public PlayerHitObject(GameObject player)
        {
            this.player = player;
        }

        void Mhl.Action.Hit.IHitObjectEvent.HitEvent(Collider selfCollider, Collider collider)
        {
            // ダメージオブジェクトに接触した
            if (collider.tag == "iron_thorns_ball")
            {
                if (player != null)
                {
                    // プレイヤーの削除
                    // オブジェクト自体削除するのでGameObject参照を消しておく
                    Object.Destroy(player.gameObject);
                    player = null;
                    UnityEngine.Debug.Log("aaa");
                }
            }
        }
    }
}