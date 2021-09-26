using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces
{
    public interface IImageListBatchRun
    {
        public event Action ResetImageSequence;
        public event Func<bool> MoveToNextImage;
    }
}
