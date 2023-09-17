namespace Engine3d.Body
{
    public struct Mesh
    {
        int[,] _tra;
        short[,] _colors;
        private float[,] _vertices;

        public bool IsVaild { get; private set; }
        public int[,] Tra {get => _tra; set {_tra = value; CheckVaild();}}
        public short[,] Colors { get => _colors; set {_colors = value; CheckVaild();} }
        public float[,] Vertices {get => _vertices;
            set {_vertices = value; CheckVaild();}}

        public void CheckVaild()
        {
            IsVaild = true;
            
            // make sure that they are in the correct height & defined 
            if ((_vertices == null) || (_vertices.GetUpperBound(1) != 2)) { IsVaild = false; return; }
            
            if ((_colors == null) || (_colors.GetUpperBound(1) != 2)) { IsVaild = false; return; }
            
            if ((_tra == null) || (_tra.GetUpperBound(1) != 2)) { IsVaild = false; return; }
            
            // make sure that tra and colors are in the same length
            if (_tra.GetUpperBound(0) != _colors.GetUpperBound(0)) { IsVaild = false; return; }
            
            // make sure that triangles are in the Vertices bound
            for (int i = 0; i <= _tra.GetUpperBound(0); i++)
            {
                if ((0 <= _tra[i, 0] && _tra[i, 0] <= _vertices.GetUpperBound(0)) &&
                    (0 <= _tra[i, 1] && _tra[i, 1] <= _vertices.GetUpperBound(0)) &&
                    (0 <= _tra[i, 2] && _tra[i, 2] <= _vertices.GetUpperBound(0))) continue;
                IsVaild = false; 
                return;
            }
            
        }
    }
}