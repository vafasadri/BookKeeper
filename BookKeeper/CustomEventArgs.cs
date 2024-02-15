using System;
namespace BookKeeper
{
    public class IdEventArgs : EventArgs
    {
        public int Id { get; set; } = -1;
    }
    public class ViewerClosingEventArgs : EventArgs
    {
        public bool Cancel { get; set; } = false;
    }
}