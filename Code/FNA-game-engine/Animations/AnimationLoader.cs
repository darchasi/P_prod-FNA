﻿using System.IO;
using System.Xml.Serialization;

namespace FNA_game_engine
{
    public static class AnimationLoader
    {
        /// <summary>
        /// Fills out a AnimationData object with all the items we need for the requested animation.
        /// </summary>
        public static AnimationData Load(string name)
        {
            //Load the XML data of the animation and return it:
            XmlSerializer serializer = new XmlSerializer(typeof(AnimationData));
            TextReader reader = new StreamReader("Content\\Animations\\" + name);
            AnimationData obj = (AnimationData)serializer.Deserialize(reader);
            reader.Close();
            return obj;
        }
    }
}
