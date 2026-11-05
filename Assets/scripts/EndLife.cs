using UnityEngine;

public class EndLife : MonoBehaviour
{
    public string TagOfDestroyer;
    public PlayerPlatform player;
    public GameObject lastLife;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == TagOfDestroyer)
        {
            if(lastLife == null){
                player.moveSpeed = 0;
                player.setFlip(false);
                player.jumpForce = 0;
            }
        }
    }
}
