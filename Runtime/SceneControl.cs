using UnityEngine;
using UnityEngine.SceneManagement;

namespace Dison.Tools
{
    /// <summary>
    /// 場景控制(載入場景 & 退出遊戲)
    /// </summary>
    public class SceneControl : MonoBehaviour
    {
        /// <summary>
        /// 載入場景
        /// </summary>
        /// <param name="sceneName">要載入的場景名子</param>
        public void LoadScene(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }

        /// <summary>
        /// 退出遊戲
        /// </summary>
        public void QuitGame()
        {
            //離開遊戲
            Application.Quit();
        }



    }
}

