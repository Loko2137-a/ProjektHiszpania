using TMPro;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    public GameObject endCoin;
    public GameObject nextLevelObject;
    public TextMeshProUGUI coinCount;

    private int totalCoins;
    private int collectedCoins = 0;

    void Start()
    {
        totalCoins = GameObject.FindGameObjectsWithTag("Coin").Length;

        if (endCoin != null)
            endCoin.SetActive(false);

        coinCount.text = "Coins: 0 / " + totalCoins;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            collectedCoins++;
            Destroy(other.gameObject);

            coinCount.text = "Coins: " + collectedCoins + " / " + totalCoins;

            if (collectedCoins >= totalCoins && endCoin != null)
            {
                endCoin.SetActive(true);
            }
        }

        if (other.CompareTag("EndCoin") && endCoin.activeSelf)
        {
            if (nextLevelObject != null)
                nextLevelObject.SetActive(true);
        }
    }
}