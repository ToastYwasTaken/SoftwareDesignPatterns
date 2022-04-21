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
            playerBuilder.InitObject();
            playerBuilder.AddCollider();
            playerBuilder.SetPosition();
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
        }
        public override void AddCollider()
        {
            //_gameObject.AddComponent<CapsuleCollider2D>();
            _player.AddCapsuleCollider();
        }

        public override void SetPosition()
        {
            //_player.transform.position = new Vector2(5,5);
            _player.transformPosition = 2;
        }
    }
}
