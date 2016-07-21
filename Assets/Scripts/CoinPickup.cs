using UnityEngine;
using System.Collections;

public class CoinPickup : MonoBehaviour {

    private PlayerController player;
    public int pointsToAdd;
    public GameObject coinParticle;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<PlayerController>() == null)
        {
            return;
        }
        Instantiate(coinParticle, player.transform.position, player.transform.rotation);
        ScoreManager.AddPoints(pointsToAdd);
        Destroy(gameObject);
    }


	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerController>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
