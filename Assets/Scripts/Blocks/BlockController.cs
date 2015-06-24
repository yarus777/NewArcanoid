using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Blocks
{
    public class BlockController : MonoBehaviour
    {

        public void Create(List<BlockInfo> blocks)
        {
            
            for (int i = 0; i < blocks.Count(); i++)
            {
                GameObject blockObject;
                switch (blocks[i].Type)
                {
                    case BlockInfo.BlockType.Wood:
                        blockObject = Instantiate(Resources.Load("Blocks/WoodBlock")) as GameObject;
                        break;
                    case BlockInfo.BlockType.Stone:
                        blockObject = Instantiate(Resources.Load("Blocks/StoneBlock")) as GameObject;
                        break;
                    case BlockInfo.BlockType.Metal:
                        blockObject = Instantiate(Resources.Load("Blocks/MetalBlock")) as GameObject;
                        break;
                    default: continue;
                }

                blockObject.transform.parent = transform;
                var block = blockObject.GetComponent<Block>();
                block.Init(blocks[i]);
                block.transform.localScale = Vector3.one;
                block.Striked += OnBlockStriked;
            }
        }

        private void OnBlockStriked(Block block, bool wasStriked)
        {
            if (wasStriked)
            Destroy(block.gameObject);
            OnBlockTouched(block);
        }


        public delegate void OnBlockTouchedDelegate(Block block);

        public event OnBlockTouchedDelegate BlockTouched;

        public void OnBlockTouched(Block block)
        {
            if (BlockTouched != null)
            {
                BlockTouched(block);
            }
        }

    }

    
}
