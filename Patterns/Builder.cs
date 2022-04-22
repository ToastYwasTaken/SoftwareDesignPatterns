using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Offloads construction of complex ojects to multiple steps
/// Example: Procedural generation, Scene Management
/// </summary>

namespace SoftwareDesignPatterns.Patterns
{

    /// <summary>
    /// Example for procedurally generating a player model in unity
    /// </summary>

    public class PlayerDirector
    {
        public void Start()
        {
            PlayerBuilder playerBuilder = new ConcretePlayer();
            InstantiatePlayer(playerBuilder);
        }
        public void InstantiatePlayer(PlayerBuilder playerBuilder)
        {
            Console.WriteLine("Starting to build new player...");
            playerBuilder.InitObject();
            playerBuilder.AddCollider();
            playerBuilder.SetPosition();
            Console.WriteLine("Successfully created new player!");
        }
    }

    public abstract class PlayerBuilder
    {
        protected GameObject _player;
        protected int _playerSpeed;
        public abstract void InitObject();
        public abstract void AddCollider();
        public abstract void SetPosition();
    }

    public class ConcretePlayer : PlayerBuilder
    {
        public override void InitObject()
        {
            _player = new GameObject("ConcretePlayer");
            _playerSpeed = 120;
            Console.WriteLine($"Called 'InitObject()' | created player: {_player} with speed: {_playerSpeed}");
        }
        public override void AddCollider()
        {
            //_gameObject.AddComponent<CapsuleCollider2D>();
            _player.AddCapsuleCollider();
            Console.WriteLine($"Called 'AddCollider()' | added capsule collider to player: {_player}");
        }
        public override void SetPosition()
        {
            //_player.transform.position = new Vector2(5,5);
            _player.transformPosition = 2;
            Console.WriteLine($"Called 'SetPosition()' | set position of player: {_player} to: {_player.transformPosition}");
        }
    }
}
