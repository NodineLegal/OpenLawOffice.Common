using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLawOffice.Common.FileSystem
{
    public class File
    {
        private Asset _asset;
        private Version _version;
        private Models.Assets.File _model;

        public Models.Assets.File Model { get { return _model; } }

        public string Path { get; private set; }

        public File(Asset asset, Version version, Models.Assets.File model)
        {
            if (asset == null) throw new ArgumentNullException("asset");
            if (version == null) throw new ArgumentNullException("version");

            _asset = asset;
            _version = version;
            _model = model;

            Path = _version.Path;

            while (Path.EndsWith("\\") || Path.EndsWith("/"))
                Path = Path.TrimEnd('\\').TrimEnd('/');

            Path += System.IO.Path.DirectorySeparatorChar.ToString() + _model.Id;
            if (!string.IsNullOrEmpty(_model.Extension))
                Path += _model.Extension;
        }
    }
}
