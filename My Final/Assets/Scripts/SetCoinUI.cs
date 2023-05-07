using UnityEngine;
using UnityEngine.UI;

public class SetCoinUI : MonoBehaviour
{
    private Text coinText;

    private void Start()
    {
        // Find Text-komponenten på dette objekt
        coinText = GetComponent<Text>();

        // Hent coins fra PlayerPrefs og opdater tekstetiketten
        int coins = PlayerPrefs.GetInt("coins");
        coinText.text = "Coins: " + coins;
        Debug.Log("SetCoinUI " + coins);
    }
}