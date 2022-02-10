using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField] private GameObject player1;
    [SerializeField] private GameObject player2;
    [SerializeField] private int player1Life = 3;
    [SerializeField] private int player2Life = 3;
    [SerializeField] private GameObject spawnPoint1;
    [SerializeField] private GameObject spawnPoint2;
    [SerializeField] private List<GameObject> p1LifeVisual;
    [SerializeField] private List<GameObject> p2LifeVisual;
    int i;
    int j;
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == player1)
        {
            player1.SetActive(false);
            player1Life -= 1;
            player1.transform.position = new Vector2(spawnPoint1.transform.position.x, spawnPoint1.transform.position.y);
            p1LifeVisual[i].SetActive(false);
            i++;
            if(player1Life > 0)
            {
                player1.SetActive(true);
            }
        }
        if (collision.gameObject == player2)
        {
            player2.SetActive(false);
            player2Life -= 1;
            player2.transform.position = new Vector2(spawnPoint2.transform.position.x, spawnPoint2.transform.position.y);
            p2LifeVisual[j].SetActive(false);
            j++;
            if (player2Life > 0)
            {
                player2.SetActive(true);
            }
        }
    }
}
