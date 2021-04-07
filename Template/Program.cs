using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class Program
    {
        static void Main(String[] args)
        {
            Game g1 = new Orcs();
            g1.Play();
            Console.WriteLine("");
            Game g2 = new Humans();
            g2.Play();
        }
    }
    public abstract class Game
    {
        protected virtual void Build()
        {
            Console.WriteLine("Budowa swiata gry");
        }
        protected virtual void Turn()
        {
            Console.WriteLine("Wskazanie gracza, ktory wykonuje ruch jako pierwszy");
        }
        protected abstract void BuildBase();
        protected abstract void Recrut();
        protected abstract void SetArmy();
        protected virtual void Attack()
        {
            Console.WriteLine("Nacje ze soba wlacza");
        }
        protected virtual void Upgrade()
        {
            Console.WriteLine("Ulepszanie ekwipunku");
        }
        public void Play()
        {
            BuildBase();
            Turn();
            Recrut();
            SetArmy();
            Attack();
            Upgrade();
        }
    }
    public class Orcs : Game
    {
        protected override void BuildBase()
        {
            Console.WriteLine("Orkowie buduja osade");
        }
        protected override void Recrut()
        {
            Console.WriteLine("Orkowie rekrutuja zolnierzy");
        }
        protected override void SetArmy()
        {
            Console.WriteLine("Orkowie wysylaja armie");
        }
        protected override void Upgrade()
        {
            Console.WriteLine("Orkowie nie potrafią ulepszac");
        }
    }
    public class Humans : Game
    {
        protected override void BuildBase()
        {
            Console.WriteLine("Ludzie buduja osade");
        }
        protected override void Recrut()
        {
            Console.WriteLine("Ludzie rekrutuja zolnierzy");
        }
        protected override void SetArmy()
        {
            Console.WriteLine("Ludzie wysylaja armie");
        }
    }
}
