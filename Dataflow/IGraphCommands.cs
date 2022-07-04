namespace IntellVega.CBB.Interfaces
{
    public interface IGraphCommands
    {
        void OnNewCommandExcute();
        void OnOpenCommandExcute();
        bool OnSaveCommandExcute();
        void OnRunCommandExcute();
        void OnRunVirtualCommandExcute();
        bool OnSaveAsCommandExcute();
    }
}
