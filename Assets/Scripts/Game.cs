using System.Collections.Generic;
using Assets.Scripts.Balls;
using Assets.Scripts.Blocks;
using Assets.Scripts.Platforms;
using UnityEngine;

namespace Assets.Scripts
{
    public class Game : MonoBehaviour
    {

        public BallController ballcontroller;
        public PlatformController platformcontroller;
        public BlockController blockcontroller;
        private LivesHandler liveshandler;
        private ScoreHandler scorehandler;
        public VisualizeText visulizetext;

        void Start ()
        {
            List<BlockInfo> newBlocks = new List<BlockInfo>();
            newBlocks.Add(new BlockInfo() {X=100, Y=200, Type = BlockInfo.BlockType.Wood});
            newBlocks.Add(new BlockInfo() { X = 300, Y = 300, Type = BlockInfo.BlockType.Stone });
            newBlocks.Add(new BlockInfo() { X = 200, Y = 400, Type = BlockInfo.BlockType.Metal });
            ballcontroller.ball.Lost += OnBallLost;
            blockcontroller.BlockTouched += OnBlockTouched;
            liveshandler = new LivesHandler(3);
            scorehandler = new ScoreHandler(0);
            visulizetext.Init(liveshandler, scorehandler);
            blockcontroller.Create(newBlocks);

        }

        private void OnBlockTouched(Block block)
        {
            scorehandler.OnBlockTouch();
        }

        private void OnBallLost(Ball ball)
        {
            ballcontroller.OnBallLost();
            platformcontroller.OnBallLost();
            liveshandler.OnBallLost();
        }
	
    }
}
