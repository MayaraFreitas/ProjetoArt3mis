using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;

    private Animator anim;
    private Inventory inventory;
    private bool playerMoving;
    private Vector2 lastMove;

    private Rigidbody2D myRigidbody;
    private Text textInfo;

    public bool canMove;
    private bool lakeArea = false;

    private const KeyCode actionButton = KeyCode.Q;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        inventory = GetComponentInParent<Inventory>();
        myRigidbody = GetComponent<Rigidbody2D>();
        canMove = true;
        textInfo = transform.GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {

        if (lakeArea && Input.GetKeyDown(KeyCode.Q))
        {
            inventory.UpdateItem("Balde Vazio", "Balde com Purpura");
        }

        if (!canMove)
        {
            myRigidbody.velocity = Vector2.zero;
            return;
        }

        playerMoving = false;
        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
            playerMoving = true;
            lastMove = new Vector2(Input.GetAxisRaw("Horizontal"), 0.0f);
        }

        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {
            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime,  0f));
            playerMoving = true;
            lastMove = new Vector2(0f, Input.GetAxisRaw("Vertical"));
        }

        anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));
        anim.SetBool("PlayerMoving", playerMoving);
        anim.SetFloat("LastMoveX", lastMove.x);
        anim.SetFloat("LastMoveY", lastMove.y);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Item")
        {
            inventory.AddItem(collision.gameObject.name, collision.gameObject);
        }
        if (collision.gameObject.tag == "Lake")
        {
            var text = transform.GetComponentInChildren<Text>();
            text.text = "Q para coletar";
            lakeArea = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        textInfo.text = string.Empty;

        if (collision.gameObject.tag == "Lake")
        {
            lakeArea = false;
        }
    }
}
