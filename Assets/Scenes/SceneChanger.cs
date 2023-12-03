using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Method to change the scene. Pass the name of the scene you want to load.
    public void ChangeScene()
    {
        SceneManager.LoadScene( 1 );
    }
}