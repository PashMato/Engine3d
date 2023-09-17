using System.Collections.Generic;
using Engine3d.Body;

namespace Engine3d.Core
{
    
    public class GameObject
    {
        // All of the game objects
        protected static List<GameObject> AllGameObjects {get; private set; } = new List<GameObject>();
        
        // non-static fields
        public float[] Pos {get; private set;} = new float[3]{0f, 0f, 0f};
        public float[] Rot {get; private set;} = new float[3]{0f, 0f, 0f};

        public string name { get; private set; } = "GameObject";

        public Mesh mesh { get; private set; } = new Mesh();

        public GameObject(string _name)
        {
            AllGameObjects.Add(this);
            
            name = _name;
        }

        public GameObject()
        {
            AllGameObjects.Add(this);
            mesh.CheckVaild();
        }

        public GameObject(string _name, float[] pos, float[] rot)
        {
            AllGameObjects.Add(this);
            mesh.CheckVaild();

            name = _name;
            
            Pos = pos;
            Rot = rot;
        }
        
        public GameObject(string _name, float[] pos, float[] rot, Mesh m)
        {
            AllGameObjects.Add(this);
            mesh.CheckVaild();

            name = _name;
            
            mesh = m;

            Pos = pos;
            Rot = rot;
        }

        ~GameObject()
        {
            AllGameObjects.Remove(this);
            mesh.CheckVaild();
        }
    }
}