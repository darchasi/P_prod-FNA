﻿using System.Collections.Generic;
using System.Xml.Serialization;


namespace FNA_game_engine
{
    public class LevelData
    {
        // XML element, clarify to xml the derived classes from gameobject
        // ADD EVERY NEW CLASS
        [XmlElement("Player", Type = typeof(Player))]
        [XmlElement("Enemy", Type = typeof(Enemy))]
        [XmlElement("PickableItem", Type = typeof(PickableItem))]
        [XmlElement("Equipement", Type = typeof(Equipement))]
        public List<GameObject> objects { get; set; }

        public List<Wall> walls { get; set; }

        public List<Decor> decor { get; set; }

        public int mapWidth { get; set; }
        public int mapHeight { get; set; }
    }
}
