﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game.backend
{
    public class PlayerObserver : IObserver
    {
        PathWalker pwInstance = PathWalker.getPathWalkerInstance();
        GameManager gameManager = GameManager.getGameManagerInstance();

        public void onIdChange()
        {
            Console.WriteLine("Player ID has changed.");
        }

        public void onIsBusyChange()
        {
            Console.WriteLine("Player isBusy has changed.");
        }

        public void onDescChange()
        {
            Console.WriteLine("Player description has changed");
        }

        public void onPosChange()
        {
            Console.WriteLine("Player position has changed.");
            pwInstance.walk(gameManager.getThisPlayer().getYPos(), gameManager.getThisPlayer().getXPos());
        }

        public void onPointChange()
        {
            Console.WriteLine("Player points have changed.");
        }
    }
}
