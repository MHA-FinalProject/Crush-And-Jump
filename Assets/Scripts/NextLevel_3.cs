using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextLevel_3 : MonoBehaviour
{
    public void GoToNextLevel()
    {
        SceneManager.LoadSceneAsync("Scene4");
    }

}
