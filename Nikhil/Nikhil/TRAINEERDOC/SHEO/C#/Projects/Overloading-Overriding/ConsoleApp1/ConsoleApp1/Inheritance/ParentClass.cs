namespace ConsoleApp1.Inheritance
{
    public class ParentClass
    {
        public string PublicGetMyName()
        {
            return "My name is TollPlus.";
        }

        //public new string Ravi()
        //{
        //    return "sai";
        //}

        public virtual string Ravi()
        {
            return "Sai";
        }


        private string PrivateGetMyName()
        {
            return "My private name";
        }

        protected string ProtectedGetMyName()
        {
            return "My protected name";
        }
    }
}
