using UnityEngine;

namespace Sempiternal.Survival.Scripts
{
    public class EnemyMove : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D rgb2D;
        [SerializeField] private SpriteRenderer spriteRenderer;
        [SerializeField] private float moveSpeed = 3f;
        
        private Transform target;

        private void Awake()
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            if (player != null)
            { 
                target = player.transform;
            }
        }

        private void Update()
        {
            if (target.position.x > transform.position.x)
            {
                spriteRenderer.flipX = false;
            }
            else if (target.position.x < transform.position.x)
            {
                spriteRenderer.flipX = true;
            }
        }

        private void FixedUpdate()
        {
            rgb2D.linearVelocity = (target.position - transform.position).normalized * moveSpeed;
        }
    }
}