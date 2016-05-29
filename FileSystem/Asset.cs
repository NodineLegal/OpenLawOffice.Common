using System.IO;

namespace OpenLawOffice.Common.FileSystem
{
    public class Asset
    {
        private Models.Assets.Asset _model;

        public Models.Assets.Asset Model { get { return _model; } }

        public string Path { get; private set; }

        public Asset(Models.Assets.Asset model)
        {
            _model = model;

            Path = Settings.Manager.Instance.FileStorage.AssetsPath;

            while (Path.EndsWith("\\") || Path.EndsWith("/"))
                Path = Path.TrimEnd('\\').TrimEnd('/');

            Path += System.IO.Path.DirectorySeparatorChar.ToString() +
                _model.Id +
                System.IO.Path.DirectorySeparatorChar.ToString();
        }
    }
}
