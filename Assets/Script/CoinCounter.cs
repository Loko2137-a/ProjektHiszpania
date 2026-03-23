using TMPro;
using UnityEngine;
public class CoinCounter : MonoBehaviour
{
    public int coinamount = 0;
    public TextMeshProUGUI coincount;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            coinamount++;
            Destroy(other.gameObject);
            coincount.text = "Coins: " + coinamount;
        }
    }
}