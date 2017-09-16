using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadSceneOnCLick : MonoBehaviour {

    public void LoadByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
