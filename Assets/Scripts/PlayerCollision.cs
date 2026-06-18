using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerScript PlayerScript;
    public Score Score;
    public GameController gameController;
    public AudioSource collectionAudio;
    public AudioSource crashAudio;
    public AudioSource winAudio;

    private void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Collectable")){
            collectionAudio.Play();
            Destroy(other.gameObject);
            Score.AddScore(1);
        }
        if(other.gameObject.CompareTag("Win")){
            winAudio.Play();
            gameController.WinGame();
            PlayerScript.enabled = false;
        }
    }
    private void OnCollisionEnter(Collision collision){
        if (collision.gameObject.CompareTag("Obstacles")){
            gameController.GameOver();  
            PlayerScript.enabled = false;
            crashAudio.Play();
        }
    }
}