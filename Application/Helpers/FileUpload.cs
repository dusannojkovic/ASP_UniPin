using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Helpers
{
    public class FileUpload
    {
        public static IEnumerable<string> AllowExtension => new List<string> { ".jpeg", ".jpg", ".png", ".gif" };
    }
}
