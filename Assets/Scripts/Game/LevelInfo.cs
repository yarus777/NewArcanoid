
using System.Collections.Generic;
using System.Xml.Serialization;
using Assets.Scripts.Blocks;

namespace Assets.Scripts
{
    public class LevelInfo
    {
        [XmlArray("Blocks")] 
        [XmlArrayItem("Block")] 
        public List<BlockInfo> Blocks;
    }
}
