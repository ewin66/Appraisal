using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appraisal.Module.Core
{
    public class Types
    {
        public enum OptionsType
        {
            FilesPath,
        }

        public enum OperationResult
        {
            InProgress = 0,
            Success,
            Fail,
        }
    }

}
