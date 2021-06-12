
namespace Mhl.Action.Hit
{
    /// <summary>
    /// 当たり判定時のイベントインターフェース
    /// </summary>
    public interface IHitObjectEvent
    {
        /// <summary>
        /// 当たり判定イベント
        /// </summary>
        /// <param name="selfCollider">自分のCollider</param>
        /// <param name="collider">当たったCollider</param>
        void HitEvent(UnityEngine.Collider selfCollider, UnityEngine.Collider collider);
    }
}