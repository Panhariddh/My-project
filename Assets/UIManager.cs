using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    [SerializeField] private Button playButton;
    public static bool Playmode = false;

    // Start is called before the first frame update
    public void PlayGame()
    {
        if (!Global.Playmode)
        {
            Global.Playmode = true;
            playButton.gameObject.SetActive(false);
        }
    }
}