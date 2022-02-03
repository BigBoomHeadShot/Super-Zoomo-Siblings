using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField] private GameObject player1;
    [SerializeField] private GameObject player2;
    [SerializeField] private int player1Life = 3;
    [SerializeField] private int player2Life = 3;
    [SerializeField] private GameObject spawnPoint;

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == player1)
        {
            player1.SetActive(false);
            player1Life -= 1;
            player1.transform.position = new Vector2(spawnPoint.transform.position.x, spawnPoint.transform.position.y);
            if(player1Life > 0)
            {
                player1.SetActive(true);
            }
        }
        if (collision.gameObject == player2)
        {
            player2.SetActive(false);
            player2Life -= 1;
            player2.transform.position = new Vector2(spawnPoint.transform.position.x, spawnPoint.transform.position.y);
            if (player2Life > 0)
            {
                player2.SetActive(true);
            }
        }
    }
}
