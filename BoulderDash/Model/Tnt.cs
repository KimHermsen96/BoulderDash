namespace BoulderDash.Model
{
    class Tnt : SlidingObject, IExplodable
    {
        public void Explode()
        {
            throw new System.NotImplementedException();
        }


        public override string ToString()
        {
            return "T";
        }
    }
}