using UnityEngine;

public class EndLife : MonoBehaviour
{
    public string TagDuPlayer;
    public PlayerPlatform player;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == TagDuPlayer)
        {
            player.moveSpeed = 0;
            player.setFlip(false);
            player.jumpForce = 0;
        }
    }
}
