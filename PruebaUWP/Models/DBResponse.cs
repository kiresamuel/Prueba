namespace PruebaUWP.Models
{
    public class DBResponse<T>
    {
        public bool ExecutionOK;
        public string Message;
        public T Data;
        public int NumRows;
    }
}