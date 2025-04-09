using UnityEngine;

namespace Sempiternal.Survival.Scripts
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private GameObject zombiePrefab;
        [SerializeField] private Zombie zombie;

        private float timer = 0f;

        private void Update()
        {
            timer += Time.deltaTime;
            if (timer > 4f)
            {
                timer = 0f;
                
                Instantiate(zombiePrefab, gameObject.transform.position, Quaternion.identity);
            }
        }
    }
}