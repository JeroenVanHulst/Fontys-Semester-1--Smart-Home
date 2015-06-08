namespace ProftaakSmartHome.Interfaces
{
    interface IDatabaseObject
    {
        int Id { get; }
        string Name { get; set; }

        void Update();
        void Remove();
        void Insert();
    }
}
