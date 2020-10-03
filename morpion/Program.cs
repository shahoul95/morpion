using System;

namespace morpion
{
    class Program
    {
        static void Main(string[] args)
        {
            MorpionEx morp = new MorpionEx();
            morp.Start();
     

        }
    }

    class MorpionEx
    {
        int[] _grille = new int[9];
        int iChoix;
        private bool IsChoixValide(int i)
        {

            if (_grille[i]  != 0)
            {
                return false;
            }
            return true;
        }
            //interdire le fait de choisir unecase déjà jouée
        private void AfficherGrille()
        {  //COnsole.WriteLine pour afficher la grille à l'écran

          
            Console.WriteLine(_grille[0] + " " + _grille[1] + " " + _grille[2]);
            Console.WriteLine(_grille[3] + " " + _grille[4] + " " + _grille[5]);
            Console.WriteLine(_grille[6] + " " + _grille[7] + " " + _grille[8]);
        }


        private bool IsPartieFinieSansVainqueur()
        {
            for (int a=0; a > _grille.Length; a++)
            {
                int c = _grille[a];
                if (_grille[a] > 0)
                {
                    return true;
                }
            }
        

            return false;

               //TODO une partie est finie sans vainqueur si aucune des cases n'est à 0 
      
        }
        private bool IsPartieGagnee()

        {

            if (_grille[0] == 1 && _grille[1] == 1 && _grille[2] == 1 || _grille[0] == 2 && _grille[1] == 2 && _grille[2] == 2)
            {
                return true;
            }
            if (_grille[3] == 1 && _grille[4] == 1 && _grille[5] == 1 || _grille[3] == 2 && _grille[4] == 2 && _grille[5] == 2)
            {
                return true;
            }
            if (_grille[6] == 1 && _grille[7] == 1 && _grille[8] == 1 || _grille[6] == 2 && _grille[7] == 2 && _grille[8] == 2)
            {
                return true;
            }
            if (_grille[0] == 1 && _grille[4] == 1 && _grille[8] == 1 || _grille[0] == 2 && _grille[4] == 2 && _grille[8] == 2)
            {
                return true;
            }
            if (_grille[2] == 1 && _grille[4] == 1 && _grille[6] == 1 || _grille[2] == 2 && _grille[4] == 2 && _grille[6] == 2)
            {
                return true;
            }

            if (_grille[0] == 1 && _grille[4] == 1 && _grille[8] == 1 || _grille[0] == 2 && _grille[4] == 2 && _grille[8] == 2)
            {
                return true;
            }
            if (_grille[1] == 1 && _grille[4] == 1 && _grille[7] == 1 || _grille[1] == 2 && _grille[4] == 2 && _grille[7] == 2)
            {
                return true;
            }
            if (_grille[3] == 1 && _grille[4] == 1 && _grille[5] == 1 || _grille[3] == 2 && _grille[4] == 2 && _grille[5] == 2)
            {
                return true;
            }
            if (_grille[0] == 1 && _grille[3] == 1 && _grille[6] == 1 || _grille[0] == 2 && _grille[3] == 2 && _grille[6] == 2)
            {
                return true;
            }
            if (_grille[2] == 1 && _grille[5] == 1 && _grille[8] == 1 || _grille[2] == 2 && _grille[5] == 2 && _grille[8] == 2)
            {
                return true;
            }
            return false;
        }
        private void AppliquerModificationSurGrille(int iChoixs, int idJoueurs)
        {

          
            _grille[iChoixs] = idJoueurs;
            
           
        }
        
        public void Start()
        {
            Console.WriteLine("Démarrons une nouvelle partie !");
            Console.WriteLine("0 1 2");
            Console.WriteLine("3 4 5");
            Console.WriteLine("6 7 8");

            int idJoueur = 1;
             
            while (true)
            {
                Console.WriteLine("Au joueur " + idJoueur + " de jouer : ");
                AfficherGrille();

               // recuperer le choix du joueur entré dans la console 
                // et assigner la variable iChoix avec l'int entré
                //.................................
                //...............................
                iChoix = Convert.ToInt32(Console.ReadLine());
                if (!IsChoixValide(iChoix))
                {
                   
                   continue;
                }

                AppliquerModificationSurGrille(iChoix, idJoueur);


                
                
                if (IsPartieGagnee())
                {
                    Console.WriteLine("Joueur " + idJoueur + " a gagné");
                    AfficherGrille();
                    break;
                }
                
                else if (IsPartieFinieSansVainqueur())
                {
                    Console.WriteLine("partie terminée sans vainqueur");
                    break;
                }
                
                idJoueur = idJoueur == 1 ? 2 : 1;
            }
        }
        
      
        
    }
}
