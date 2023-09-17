namespace _3dEngine.Core
{
    public class Camera : GameObject
    {
        float _feildOfView = 60f;
        
        public Camera(float f, string name, float[] Pos, float[] Rot) : base(name, Pos, Rot)
        {
            _feildOfView = f;
        }
        
        public Camera(float f)
        {
            _feildOfView = f;
        }

        public Camera() { }

        void Update()
        {
            foreach (GameObject gameObject in AllGameObjects)
            {
                if (gameObject.mesh.IsVaild)
                {
                    Draw();
                }
            }
        }

        void Draw()
        {
            
        }
    }
}