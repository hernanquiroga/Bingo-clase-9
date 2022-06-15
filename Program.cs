// Bingo

Console.WriteLine("Su carton de bingo es el siguiente :");



int[] carton = new int[27];


  for (int i = 0; i < 27; i++)
    {
       if (i == 0)
        {                                           // Primera fila
            Random num = new Random();
            carton[i] = num.Next(1,3);
        }
        else if (i == 1) {
            Random num = new Random();
            carton[i] = num.Next(10,12);
        } 
        else if (i == 2) {
            Random num = new Random();
            carton[i] = num.Next(20, 23);
        } 
        else if (i == 3)   {
            Random num = new Random();
            carton[i] = num.Next(30, 33);
        } 
        else if (i == 4)   {
            Random num = new Random();
            carton[i] = num.Next(40, 43);
        } 
        else if (i == 5)   {
            Random num = new Random();
            carton[i] = num.Next(50, 53);
        }
        else if (i == 6)   {
            Random num = new Random();
            carton[i] = num.Next(60, 63);
        } 
        else if (i == 7)   {
            Random num = new Random();
            carton[i] = num.Next(70, 73);
        } 
        else if (i == 8)   {
            Random num = new Random();
            carton[i] = num.Next(80, 84);               // Segunda fila
        } 
        else if (i == 9)
        {
            Random num = new Random();
            carton[i] = num.Next(4, 6);
        } 
        else if (i == 10)
        {
            Random num = new Random();
            carton[i] = num.Next(13, 15);
        } 
        else if (i == 11)
        {
            Random num = new Random();
            carton[i] = num.Next(24, 26);
        } 
        else if (i == 12)
        {
            Random num = new Random();
            carton[i] = num.Next(34, 36);
        } 
        else if (i == 13)
        {
            Random num = new Random();
            carton[i] = num.Next(44, 46);
        } 
        else if (i == 14)
        {
            Random num = new Random();
            carton[i] = num.Next(54, 56);
        } 
        else if (i == 15)
        {
            Random num = new Random();
            carton[i] = num.Next(64, 66);
        } 
        else if (i == 16)
        {
            Random num = new Random();
            carton[i] = num.Next(74, 76);
        } 
        else if (i == 17)
        {
            Random num = new Random();
            carton[i] = num.Next(85, 87);              // Tercera fila
        } 
        else if (i == 18)
        {
            Random num = new Random();
            carton[i] = num.Next(7,9);
        }
        else if (i == 19)
        {
            Random num = new Random();
            carton[i] = num.Next(16, 19);
        }  
        else if (i == 20)
        {
            Random num = new Random();
            carton[i] = num.Next(27, 29);
        }  
        else if (i == 21)
        {
            Random num = new Random();
            carton[i] = num.Next(37, 39);
        }  
        else if (i == 22)
        {
            Random num = new Random();
            carton[i] = num.Next(47, 49);
        }  
        else if (i == 23)
        {
            Random num = new Random();
            carton[i] = num.Next(57, 59);
        }  
        else if (i == 24)
        {
            Random num = new Random();
            carton[i] = num.Next(67, 69);
        }  
        else if (i == 25)
        {
            Random num = new Random();
            carton[i] = num.Next(77, 79);
        }
        else if (i == 26)
        {
            Random num = new Random();
            carton[i] = num.Next(88, 90);
        }

    }


// Borro al azar 4 casillas por fila

for (int i = 0; i < 4; i++)
    {
       Random fila = new Random();
       int indice = fila.Next(0, 8);
       carton[indice] = 0;
    }

for (int i = 0; i < 4; i++)
{
    Random fila = new Random();
    int indice = fila.Next(9, 17);
    carton[indice] = 0;
}

for (int i = 0; i < 4; i++)
{
    Random fila = new Random();
    int indice = fila.Next(18, 26);
    carton[indice] = 0;
}


// Imprimo el Carton

for (int i = 0; i < 9; i++)
{
    if (carton[i] == 0)
    {
        Console.Write(" - ");
    } else
    {
        Console.Write(carton[i]);
    }
    Console.Write(" | ");
}

Console.WriteLine();

for (int i = 9; i < 18; i++)
{
    if (carton[i] == 0)
    {
        Console.Write(" - ");
    }
    else
    {
        Console.Write(carton[i]);
    }
    Console.Write(" | ");
}

Console.WriteLine();

for (int i = 18; i < 27; i++)
{
    if (carton[i] == 0)
    {
        Console.Write(" - ");
    }
    else
    {
        Console.Write(carton[i]);
    }
    Console.Write(" | ");
}
