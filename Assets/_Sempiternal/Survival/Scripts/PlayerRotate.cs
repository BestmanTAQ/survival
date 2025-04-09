using UnityEngine;

namespace Sempiternal.Survival.Scripts
{
    public class PlayerRotate : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer gun;
        [SerializeField] private GameObject bullerSpawner;

        private Camera mainCamera;

        private void Awake()
        {
            mainCamera = Camera.main;
        }

        private void Update()
        {
            Vector3 mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);

            if (mousePos.x < transform.position.x)
            {
                transform.localRotation = Quaternion.Euler(0, 180, 0);
                gun.flipY = true;
            }
            else if (mousePos.x > transform.position.x)
            {
                transform.localRotation = Quaternion.Euler(0, 0, 0);
                gun.flipY = false;
            }
        }
    }
}