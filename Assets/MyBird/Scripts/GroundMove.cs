using UnityEngine;

namespace MyBird
{
    public class GroundMove : MonoBehaviour
    {
        #region Variables
        [SerializeField] private float moveSpeed = 5f;
        #endregion

        // Update is called once per frame
        void Update()
        {
            MoveGround();
        }

        void MoveGround()
        {
            if(GameManager.IsDeath)
                return;

            transform.Translate(Vector3.left * Time.deltaTime * moveSpeed, Space.World);

            if (transform.localPosition.x <= -8.4f)
            {
                transform.localPosition = new Vector3(transform.localPosition.x + 8.4f, transform.localPosition.y, transform.localPosition.z);
            }
        }
    }
}