namespace ProftaakSmartHome.Interfaces
{
    interface IDatabaseObject
    {
        int Id { get; }
        string Name { get; set; }

        void Update();
        bool Remove();
        void Insert();
    }
}
