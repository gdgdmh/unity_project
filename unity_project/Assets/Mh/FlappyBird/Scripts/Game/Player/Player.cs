using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mh.Flappybird
{
    public class Player : MonoBehaviour
    {
        public static readonly Vector3 moveRight = new Vector3(3.0f, 0.0f, 0.0f);
        public static readonly Vector3 moveDown = new Vector3(0.0f, -2.0f, 0.0f);
        public static readonly Vector3 moveUp = new Vector3(0.0f, 35.0f, 0.0f);
        public static readonly float MaxDownSpeed = -7.0f;
        public static readonly float MaxForwardSpeed = 2.0f;
        public Vector3 velocity = new Vector3(0.0f, 0.0f, 0.0f);
        private Collider playerCollider = null;
        private Mhl.Input.GameController.GameController controller = null;
        private Mhl.Action.Hit.IHitObjectEvent hitObjectEvent = null;

        /// <summary>
        /// 開始
        /// </summary>
        void Start()
        {
            ApplyVelocity();
            playerCollider = GetComponent<Collider>();
            controller = new Mhl.Input.GameController.GameController();
            hitObjectEvent = new PlayerHitObject(this.gameObject);
        }

        /// <summary>
        /// 更新処理
        /// </summary>
        void Update()
        {
            UpdateController();
            InputProcess();
            MoveRight();
            MoveDown();
            ApplyVelocity();
            SetVelocityXLimit();
            SetVelocityYLimit();
        }

        void UpdateController()
        {
            // コントローラー処理の更新
            Debug.Assert(controller != null);
            controller.Update();
        }

        void InputProcess()
        {
            if ((controller.IsButtonDown(Mhl.Input.GameController.GameControllerConstant.Button.A))
                || (controller.IsButtonDown(Mhl.Input.GameController.GameControllerConstant.Button.B))
                || (controller.IsButtonDown(Mhl.Input.GameController.GameControllerConstant.Button.X))
                || (controller.IsButtonDown(Mhl.Input.GameController.GameControllerConstant.Button.Y)))
            {
                MoveJump();
            }
        }

        /// <summary>
        /// VelocityをRigidbodyに適用する
        /// </summary>
        private void ApplyVelocity()
        {
            Rigidbody rbody = GetComponent<Rigidbody>();
            UnityEngine.Assertions.Assert.IsNotNull(rbody);
            rbody.velocity = velocity;
        }

        /// <summary>
        /// 右移動(右移動用のベクトルをマージ)
        /// </summary>
        private void MoveRight()
        {
            MergeVelocity(out velocity, velocity, moveRight);
        }

        /// <summary>
        /// 下移動(下移動用のベクトルをマージ)
        /// </summary>
        private void MoveDown()
        {
            MergeVelocity(out velocity, velocity, moveDown);
        }

        /// <summary>
        /// Xベクトルの速度制限設定
        /// </summary>
        private void SetVelocityXLimit()
        {
            if (velocity.x > MaxForwardSpeed)
            {
                velocity.x = MaxForwardSpeed;
            }
        }

        /// <summary>
        /// Yベクトルの速度制限設定
        /// </summary>
        private void SetVelocityYLimit()
        {
            if (velocity.y < MaxDownSpeed)
            {
                velocity.y = MaxDownSpeed;
            }
        }

        /// <summary>
        /// ベクトルに0を設定
        /// </summary>
        private void SetZeroVelocity()
        {
            velocity.x = 0.0f;
            velocity.y = 0.0f;
            velocity.z = 0.0f;
        }

        /// <summary>
        /// ジャンプ処理
        /// </summary>
        private void MoveJump()
        {
            velocity.y = 0.0f; // 落下ベクトルをリセット
            MergeVelocity(out velocity, velocity, moveUp);
        }

        /// <summary>
        /// ベクトルのマージ
        /// </summary>
        /// <param name="mergeResult">マージ結果のベクトル</param>
        /// <param name="merge1">マージ対象のベクトル1</param>
        /// <param name="merge2">マージ対象のベクトル2</param>
        private void MergeVelocity(out Vector3 mergeResult, Vector3 merge1, Vector3 merge2)
        {
            mergeResult = merge1 + merge2;
        }

        /// <summary>
        /// 当たり判定(Enter)
        /// </summary>
        /// <param name="other">ヒットした対象</param>
        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("OnTriggerEnter(Player) tag(" + other.tag + ") name(" + other.name + ")");
            hitObjectEvent.HitEvent(playerCollider, other);
            if (this.gameObject == null)
            {
                // 消された時は来ないっぽいのでDelegateで伝える必要あり
                Debug.Log("Deleted");
            }
        }

        /// <summary>
        /// ゲームオーバー処理
        /// </summary>
        private void OnGameOver()
        {
        }
    }
}