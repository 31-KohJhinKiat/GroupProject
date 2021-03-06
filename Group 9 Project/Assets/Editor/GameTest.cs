using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class GameTest
    {
        private GameManager game;
        private SpawnerScript spawn;
        private PlayerScript player;
        private LaserScript laser;

        [SetUp]
        public void Setup()
        {
            GameObject gameGameObject = 
                MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/GameManager"));

            GameObject spawnGameObject =
                MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/Spawner"));

            GameObject shipGameObject =
               MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/PlayerShip"));

            GameObject laserGameObject =
               MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/laser"));

            game = gameGameObject.GetComponent<GameManager>();
            player = shipGameObject.GetComponent<PlayerScript>();
            spawn = spawnGameObject.GetComponent<SpawnerScript>();
            laser = spawnGameObject.GetComponent<LaserScript>();
        }

        

        [TearDown]
        public void Teardown()
        {
            Object.Destroy(game.gameObject);
        }

        [UnityTest]
        public IEnumerator AsteroidsMoveDown()
        {

            // 3
            GameObject asteroid = spawn.SpawnObjects();
            // 4
            float initialYPos = asteroid.transform.position.y;
            // 5
            yield return new WaitForSeconds(0.1f);
            // 6
            Assert.Less(asteroid.transform.position.y, initialYPos);
            // 7
            Object.Destroy(game.gameObject);
        }

        [UnityTest]
        public IEnumerator CollisionWithSpawnObject()
        {

            GameObject spawnObject = spawn.SpawnObjects();
            //1
            spawnObject.transform.position = player.transform.position;
            player.playerHealth = 50;
            //2
            yield return new WaitForSeconds(0.1f);

            //3
            if(spawnObject.tag == "obstacles")
            {
                Assert.True(player.playerHealth < 50);
            }
            else
            {
                Assert.True(player.playerHealth > 50);
            }

            Object.Destroy(game.gameObject);
        }

        [UnityTest]
        public IEnumerator LaserMovesUp()
        {
            // 1
            laser.transform.position = player.transform.position;
            // 2
            float initialYPos = laser.transform.position.y;
            yield return new WaitForSeconds(0.1f);
            // 3
            Assert.Greater(laser.transform.position.y, initialYPos);
        }

        [UnityTest]
        public IEnumerator TestScriptPasses()
        {

            yield return null;
        }

    }
}
