namespace InterfaceDemo
{
    internal interface IDestroyable
    {
        public string DestructionSound { get; set; }

        void Destroy();
    }
}
