using UnityEngine;

public class parede : MonoBehaviour
{
    public float Velocidade;
    public enum Direction { Up, Down, Left, Right, Forward, Back }
    public Direction direction;

    void Start()
    {
        Destroy(gameObject, 5f);
    }
    void Update()
    {
        this.changeDiretion(direction);
    }

    private void changeDiretion(Direction direct)
    {
        switch (direct)
        {
            case Direction.Forward:
                transform.Translate(Vector3.forward * Velocidade * Time.deltaTime);
                break;
            case Direction.Back:
                transform.Translate(Vector3.back * Velocidade * Time.deltaTime);
                break;
            case Direction.Left:
                transform.Translate(Vector3.left * Velocidade * Time.deltaTime);
                break;
            case Direction.Right:
                transform.Translate(Vector3.right * Velocidade * Time.deltaTime);
                break;
            case Direction.Up:
                transform.Translate(Vector3.up * Velocidade * Time.deltaTime);
                break;
            case Direction.Down:
                transform.Translate(Vector3.down * Velocidade * Time.deltaTime);
                break;
        }
    }

}
