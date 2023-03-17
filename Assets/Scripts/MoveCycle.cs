using UnityEngine;

public class MoveCycle : MonoBehaviour
{
    public Vector2 direction = Vector2.right;
    public float speed = 1f;
    public int size = 1;

    private Vector3 leftEdge;
    private Vector3 rightEdge;

    private void Start() 
    {
        leftEdge = Camera.main.ViewportToWorldPoint(Vector3.zero);
        rightEdge = Camera.main.ViewportToWorldPoint(Vector3.right);   
    }

    private void Update() 
    {
        if(direction.x > 0 && (transform.position.x - size) > rightEdge.x)
        {
            Vector3 Position = transform.position;
            Position.x = leftEdge.x - size;
            transform.position = Position;
        }
        else if(direction.x < 0 && (transform.position.x + size) < leftEdge.x)
        {
            Vector3 Position = transform.position;
            Position.x = rightEdge.x + size;
            transform.position = Position;
        }
        else
        {
            transform.Translate(direction * speed * Time.deltaTime);
        }    
    }
}
