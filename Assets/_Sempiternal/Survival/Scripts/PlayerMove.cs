using UnityEngine;
using UnityEngine.UI;

namespace Sempiternal.Survival.Scripts
{
    public class PlayerMove : MonoBehaviour
    {
        private static readonly int Death = Animator.StringToHash("Death");
        private static readonly int Run = Animator.StringToHash("Run");
        [SerializeField] private Rigidbody2D rgb2D;
        [SerializeField] private Animator animator;
        [SerializeField] private Camera mainCamera;
        [SerializeField] private BoxCollider2D boxCollider2D;
        [SerializeField] private float moveSpeed = 5f;
        [SerializeField] private GameObject weapon;
        [SerializeField] private PlayerMove playerMove;
        [SerializeField] private PlayerRotate playerRotate;
        [SerializeField] private Slider slider;
        [SerializeField] private GameObject deathScreen;
        
        private float horizontalInput;
        private float verticalInput;
        
        public float hitPoint = 100f;

        private void Update()
        {   
            horizontalInput = Input.GetAxis("Horizontal");
            verticalInput = Input.GetAxis("Vertical");

            if (verticalInput != 0 || horizontalInput != 0)
            {
                animator.SetBool(Run, true);
            }
            else
            {
                animator.SetBool(Run, false);
            }

            if (hitPoint <= 0)
            {
                Die();
            }
            
            slider.value = hitPoint;
        }

        private void FixedUpdate()
        {
            Vector2 movement = new Vector2(horizontalInput, verticalInput).normalized;
            rgb2D.linearVelocity = movement * moveSpeed;
        }

        private void LateUpdate()
        {
            mainCamera.transform.position = new Vector3(transform.position.x, transform.position.y, -10f);
        }
        
        private void Die()
        {
            animator.SetTrigger(Death);
            boxCollider2D.enabled = false;
            playerRotate.enabled = false;
            rgb2D.linearVelocity = Vector2.zero;
            Destroy(weapon);
            playerMove.enabled = false;
            deathScreen.SetActive(true);
        }
    }
}
