using UnityEngine;
using System.Collections;

namespace UnityChan
{
	[ExecuteInEditMode]
	public class SplashScreen : MonoBehaviour
	{
		void NextLevel ()
		{
            // 旧形式の警告が出ていたため、書き換え(動作確認はしていない)
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name + 1);
			//Application.LoadLevel(Application.loadedLevel + 1);
		}
	}
}