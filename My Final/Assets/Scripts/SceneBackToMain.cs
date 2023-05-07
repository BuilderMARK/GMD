using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneBackToMain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnButtonClick()
    {
        SceneManager.LoadScene("SceneNavn");
    }
    // Update is called once per frame
    void Update()
    {
    }
}
