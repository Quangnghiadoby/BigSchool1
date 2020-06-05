namespace BigSchool.Models
{
    public class IndentityDbContext<T>
    {
        private bool throwIfV1Schema;
        private string v;

        public IndentityDbContext(string v, bool throwIfV1Schema)
        {
            this.v = v;
            this.throwIfV1Schema = throwIfV1Schema;
        }
    }
}