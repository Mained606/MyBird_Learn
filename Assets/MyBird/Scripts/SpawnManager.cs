using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyBird
{
    public class SpawnManager : MonoBehaviour
    {
        #region 
        // 코루틴 사용하여 구현
        // //파이프 프리팹
        // public GameObject pipePrefab;
        // //스폰 체크
        // private bool isSpawning = false;

        // 스폰 타이머 사용하여 구현
        // 스폰할 파이프 프리팹
        public GameObject pipePrefab;


        //스폰 타이머
        // [SerializeField] private float spawnTimer = 1.0f;
        private float countdown = 0f;
        [SerializeField] private float minSpawnTimer = 0.95f;
        [SerializeField] private float maxSpawnTimer = 1.05f;
        public static float levelTime = 0f;


        // 스폰 위치
        [SerializeField] private float maxSpawnY = 3.5f;
        [SerializeField] private float minSpawnY = -1.5f;
        #endregion
        void Start()
        {
            //초기화
            countdown = Random.Range(minSpawnTimer, maxSpawnTimer);
        }

        void Update()
        {
            //코루틴 사용하여 구현
            // if (GameManager.IsStart && !isSpawning)
            // {
            //     isSpawning = true;
            //     StartCoroutine(SpawnPipe());
            // }

            // 게임 시작 안하면 리턴
            if(GameManager.IsStart == false)
                return;

            if(countdown <= 0f)
            {
                SpawnPipe();
                countdown = Random.Range(minSpawnTimer, maxSpawnTimer);
            }
            countdown -= Time.deltaTime;
        }

        // 코루틴 사용하여 구현
        // IEnumerator SpawnPipe()
        // {
        //     while (true)
        //     {
        //         //1초 지연
        //         yield return new WaitForSeconds(1f);
        //         //랜덤한 위치에 생성
        //         float randomY = Random.Range(-1.5f, 3.5f);
        //         GameObject pipe = Instantiate(pipePrefab, new Vector3(this.transform.position.x, randomY, this.transform.position.z), Quaternion.identity);   
        //         DestroyPipe(pipe);
        //     }
        // }

        // 파이프 생성
        void SpawnPipe()
        {
            if(GameManager.IsDeath)
                return;

            float spawnY = transform.position.y + Random.Range(minSpawnY, maxSpawnY);
            Vector3 spawnPosition = new Vector3(this.transform.position.x, spawnY, 0f);
            GameObject pipe = Instantiate(pipePrefab, spawnPosition, Quaternion.identity);   
        }

        // // 파이프 파괴
        // void DestroyPipe(GameObject pipe)
        // {
        //     if(GameManager.IsDeath)
        //         return;

        //     Destroy(pipe, 3f);
        // }
    }


}
