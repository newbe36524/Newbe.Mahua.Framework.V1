namespace Newbe.Mahua.QQLight
{
    public interface IQqLightAuthCodeContainer
    {
        int AuthCode { get; set; }

        void Save();

        void Load();
    }
}
