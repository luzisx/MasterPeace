﻿
using System.Linq;
using Thammapirom.Models;
using Thammapirom.Concrete;
namespace Thammapirom.Abstract
{
    public interface IBackgroundRepository
    {
        IQueryable<Background> Backgrounds { get; }
        void SaveBackgroundInfo(Background background);
        Background ClearBackgroundInfo(int backgroundID);
    }
}