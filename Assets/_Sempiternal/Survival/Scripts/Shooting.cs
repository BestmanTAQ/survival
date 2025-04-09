using System.Collections;
using UnityEngine;

namespace Sempiternal.Survival.Scripts
{
    public class Shooting : MonoBehaviour
    {
        [SerializeField] private GameObject bulletPrefab;
        [SerializeField] private Transform bulletSpawn;
        [SerializeField] private GameObject explosion;

        private void Update()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                StartCoroutine(Fire());
                StartCoroutine(Explosion());
            }
        }

        private IEnumerator Fire()
        {
            var activeBullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
            yield return new WaitForSecondsRealtime(4f);
            Destroy(activeBullet);
        }

        private IEnumerator Explosion()
        {
            var activeExplosion = Instantiate(explosion, bulletSpawn.transform.position, bulletSpawn.rotation, bulletSpawn);
            yield return new WaitForSeconds(0.5f);
            Destroy(activeExplosion);
        }
    }
}