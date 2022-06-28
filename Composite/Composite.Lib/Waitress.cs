namespace Composite.Lib
{
    public class Waitress
    {
        private MenuComponent _allMenus;

        public Waitress(MenuComponent allMenus)
        {
            _allMenus = allMenus;
        }

        public void PrintMenu() 
        {
            _allMenus.Print();
        }
    }
}
