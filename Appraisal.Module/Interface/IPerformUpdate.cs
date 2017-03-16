namespace Appraisal.Module.Interface
{
    public interface IPerformUpdate
    {
        void ShowDialog();
        void HideDialog();
        void Cancel();
        int ProgressMax { get; set; }
        int ProgressValue { get; set; }
    }
}