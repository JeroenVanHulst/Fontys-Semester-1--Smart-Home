namespace ProftaakSmartHome.Interfaces
{
    interface IDatabaseObject
    {
        int Id { get; set; }
        string Name { get; set; }

        void Update();
        void Remove();
        void Insert();
    }
}
