using UnityEngine;
using UnityEngine.SceneManagement;

namespace Sempiternal.Survival.Scripts
{
    public class RestartLevel : MonoBehaviour

    {
        public void Restart()
        {
            SceneManager.LoadScene(0);
        }
    }
}