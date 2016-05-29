using System;

namespace OpenLawOffice.Common.FileSystem
{
    public class Version
    {
        private Asset _asset;
        private Models.Assets.Version _model;

        public Models.Assets.Version Model { get { return _model; } }

        public string Path { get; private set; }

        public Version(Asset asset, Models.Assets.Version model)
        {
            if (asset == null) throw new ArgumentNullException("asset");

            _asset = asset;
            _model = model;

            Path = asset.Path;

            while (Path.EndsWith("\\") || Path.EndsWith("/"))
                Path = Path.TrimEnd('\\').TrimEnd('/');

            Path += System.IO.Path.DirectorySeparatorChar.ToString() +
                _model.SequenceNumber +
                System.IO.Path.DirectorySeparatorChar.ToString();
        }
    }
}
