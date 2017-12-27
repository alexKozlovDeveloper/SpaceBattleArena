using SpaceBattleArena.Core.PlayersEntityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceBattleArena.Core.MapEntityes
{
    public class Map
    {
        public List<Player> Players;

        public List<Bullet> Bullets;

        public Map()
        {
            Players = new List<Player>();
            Bullets = new List<Bullet>();
        }
    }
}
