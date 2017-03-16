using System.ComponentModel;
using System.Runtime.CompilerServices;
using Appraisal.Module.Core;


namespace Appraisal.Module.Model
{
    public sealed class UpdateFile : INotifyPropertyChanged
    {
        public UpdateFile(string filePath)
        {
            FilePath = filePath;
            OpResult = Types.OperationResult.InProgress;
            ResultMsg = string.Empty;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string _filePath;
        public string FilePath
        {
            get { return _filePath; }
            set
            {
                _filePath = value;
                OnPropertyChanged();
            }
        }

        private Types.OperationResult _opResult;
        public Types.OperationResult OpResult
        {
            get { return _opResult; }
            set
            {
                _opResult = value;
                OnPropertyChanged(); 
            }
        }

        private string _resultMsg;
        public string ResultMsg
        {
            get { return _resultMsg; }
            set
            {
                _resultMsg = value;
                OnPropertyChanged();
            }
        }


    }

}