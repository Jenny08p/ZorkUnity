namespace Zork_Common
{
    public interface IOutputService
    {
        void WriteLine(string value);

        void WriteLine(object value);

        void Write(string value);

        void Write(object value);

        void Clear();


    }
}
