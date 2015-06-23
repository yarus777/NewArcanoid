
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
        public BlockType type;
        public int X;
        public int Y;
    }
}
