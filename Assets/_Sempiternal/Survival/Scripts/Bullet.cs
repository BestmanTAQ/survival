using UnityEngine;

namespace Sempiternal.Survival.Scripts
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D rgb2D;

        private void FixedUpdate()
        {
            rgb2D.linearVelocity = transform.TransformDirection(new Vector2(0, 10));
        }
    }
}