
using System;
using System.Xml.Serialization;

namespace Assets.Scripts.Blocks
{
   public class BlockInfo
    {
       public enum BlockType
       {
           Wood,
           Stone,
           Metal
       }
       [XmlElement("Type")]
        public BlockType Type;
       [XmlElement("X")]
        public int X;
       [XmlElement("Y")]
        public int Y;
    }
}
