using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace MyBird
{
    public class TitleUI : MonoBehaviour
    {
        #region Variables
        [SerializeField] private string loadToScene = "PlayScene";
        #endregion

        private void Update()
        {
            //치팅
            if(Input.GetKeyDown(KeyCode.P))
            {
                ResetGameData();
            }
        }

        public void Play()
        {
            SceneManager.LoadScene(loadToScene);
        }

        void ResetGameData()
        {
            PlayerPrefs.DeleteAll();
        }
    }

}


