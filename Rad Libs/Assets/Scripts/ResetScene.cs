using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ResetScene : MonoBehaviour 
{
	void OnGUI() 
	{
     if (GUILayout.Button("Resettttt")) 
	 {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
     }
 }
	
}
