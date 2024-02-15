namespace BookKeeper
{

    internal interface IViewer
    {
        int ModelID { get; }
        string DisplayName { get; }
        void Initialize(UnitOfWork unitOfWork);
        void LoadModel(int modelID);
        void ViewerClosing(object sender, ViewerClosingEventArgs eventArgs);
    }
}
