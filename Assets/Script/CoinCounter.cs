using TMPro;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    public GameObject finalCoin;
    public GameObject nextLevelObject;
    public int coinAmount = 0;
    public TextMeshProUGUI coinCount;
    public TextMeshProUGUI endPanel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            coinAmount++;
            Destroy(other.gameObject);
            coinCount.text = "Coins: " + coinAmount;

            if (coinAmount == 4 && finalCoin != null)
            {
                finalCoin.SetActive(true);
            }
        }

        if (other.CompareTag("EndCoin") && nextLevelObject != null)
        {
            nextLevelObject.SetActive(true);
        }
    }
}