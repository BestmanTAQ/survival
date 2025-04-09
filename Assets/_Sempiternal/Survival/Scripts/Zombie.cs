using UnityEngine;

namespace Sempiternal.Survival.Scripts
{
    public class Zombie : MonoBehaviour
    {
        private static readonly int Hit = Animator.StringToHash("Hit");
        private static readonly int Dead = Animator.StringToHash("Dead");
        [SerializeField] private Animator animator;
        [SerializeField] private EnemyMove enemyMove;
        [SerializeField] private BoxCollider2D boxCollider2D;
        [SerializeField] private Rigidbody2D rgb2D;
        private PlayerMove playerMove;

        private float HitPoint { get; set; } = 100f;
        
        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Bullet"))
            {
                Destroy(other.gameObject);
                HitPoint -= 10f;
                if (HitPoint <= 0f)
                {
                    Die();
                }
                animator.SetTrigger(Hit);
            }
        }

        void OnCollisionStay2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                playerMove = other.gameObject.GetComponent<PlayerMove>();
                playerMove.hitPoint -= 1f;
                Debug.Log(playerMove.hitPoint);
            }
        }

        private void Die()
        {
            animator.SetBool(Dead, true);
            enemyMove.enabled = false;
            boxCollider2D.enabled = false;
            rgb2D.linearVelocity = Vector2.zero;
            Destroy(gameObject, 4f);
        }
    }
}