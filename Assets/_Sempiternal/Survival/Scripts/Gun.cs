using UnityEngine;

namespace Sempiternal.Survival.Scripts
{
    public class Gun : MonoBehaviour
    {
        private Camera mainCamera;

        private void Awake()
        {
            mainCamera = Camera.main;
        }

        private void Update()
        {
            Vector3 playerPosition = transform.position;
            Vector3 mouse = mainCamera.ScreenToWorldPoint(Input.mousePosition) - playerPosition;
            float rotateAngle = Mathf.Atan2(mouse.y, mouse.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, rotateAngle);
        }
    }
}
