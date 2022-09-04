void Printer (int [,] Array, int coord_1, int coord_2) 
  {

for (int i = 0; i < coord_1; i++)
  {
      for (int j = 0; j < coord_2; j++)
      {
        Console.Write(Array[i, j] + " ");
      }
      Console.WriteLine();
  } 
  Console.WriteLine();
  };

// Task 54

int a = 5;
int b = 5;
int [,] Array_54 = new int [a,b];
for (int i = 0; i < a; i++)
  {
    for (int j = 0; j < b; j++)
    {
        var RND_54 = new Random ();
      Array_54[i, j] = RND_54.Next(0,11);
    }
  };
  // Printing the initial array
  Printer(Array_54, a, b);
  // Counter and assembler

  int temp = 0;

  for (int i = 0; i < a; i++)
  {
    for (int u = 0; u < b-1;u++)
    {
      for (int j = 0; j < b-u-1; j++)
    {
        if (Array_54[i,j]<Array_54[i,j+1])
        {temp = (Array_54[i,j+1]);
        Array_54[i,j+1]=Array_54[i,j];
        Array_54[i,j]=temp;};
  };
  };
  };
// Printing the amended array
  Printer(Array_54, a, b);
  // Task 56
Console.WriteLine();
Console.WriteLine();

int z = 5;
int x = 4;
int [,] Array_56 = new int [z,x];
for (int i = 0; i < z; i++)
  {
    for (int j = 0; j < x; j++)
    {
        var RND_56 = new Random ();
      Array_56[i, j] = RND_56.Next(0,11);
    }
  };
// Printing the initial array
   Printer(Array_56, z, x);

int Result = 0;
int Min = int.MaxValue;
int Min_i = 0;

 for (int i = 0; i < z; i++)
  {
    Result = 0;
      for (int j = 0; j < x; j++)
    {
      Result = Result + Array_56[i,j];
  };
  if (Result<Min)
  {
    Min = Result;
    Min_i = i+1;
  }
  };

  Console.WriteLine("The line with the minimal sum of numbers is line {0}, the sum of elements is {1}", Min_i, Min );

  // Task  58
Console.WriteLine();
Console.WriteLine();

int coord_y = 5;
int coord_x = 4;

int [,] Array_58_1 = new int [coord_y, coord_x];
int [,] Array_58_2 = new int [coord_y, coord_x];

for (int i = 0; i < coord_y; i++)
  {
    for (int j = 0; j < coord_x; j++)
    {
        var RND_58 = new Random ();
      Array_58_1[i, j] = RND_58.Next(0,11);
      Array_58_2[i, j] = RND_58.Next(0,11);
    }
  };

  Printer(Array_58_1,coord_y,coord_x);
  Printer(Array_58_2,coord_y,coord_x);
int [,] Array_58_3 = new int [coord_y, coord_x];
for (int i = 0; i < coord_y; i++)
  {
    for (int j = 0; j < coord_x; j++)
    {
Array_58_3 [i,j] = Array_58_1 [i,j]*Array_58_2[i,j];
    };
  };

Printer(Array_58_3, coord_y, coord_x);

// Task 
 int coord_a = 4;
 int coord_b = 4;
 int numbers = 1;
 int counter =1;
 int current_coord_1 = 0;
 int current_coord_2 = 0;
 int [,] Array_62 = new int [coord_a, coord_b];

int Direction_filler (int [,] Array, int coord_1, int coord_2, int current_coord_1, int current_coord_2, int numbers, int counter)
{
if (counter == 1)
{
  if (current_coord_2 != coord_2-1)
  {
  if (Array[current_coord_1, current_coord_2+1] == 0)
  {
    for (int i = current_coord_2; i < coord_2; i++)
  {
    Array[current_coord_1, i] = numbers;
    numbers++;
    current_coord_2 = i;
    if (i != coord_2-1)
    {
    if (Array[current_coord_1, i+1] != 0)
    {
      i = coord_2;
    };
    };
  };
  };
  };
  if (current_coord_1 != coord_1-1)
  {
  if (Array[current_coord_1+1,current_coord_2] == 0)
  {
      for (int i = current_coord_1+1; i < coord_1; i++)
  {
   Array[i, current_coord_2] = numbers;
   numbers++;
   current_coord_1 = i;
    if (i != coord_1-1)
    {
    if (Array[i+1, current_coord_2] != 0)
    {
      i = coord_1;
    };
    };  
  }
  counter++;
  Direction_filler(Array_62,coord_a,coord_b,current_coord_1,current_coord_2,numbers,counter);
  }
}
}
else if (counter == 2)
{
  for (int i = current_coord_2-1; i > -1; i--)
  {
    Array[current_coord_1, i] = numbers;
    numbers++;
    current_coord_2 = i;
    if (i != 0)
    {
    if (Array[current_coord_1, i-1] != 0)
    {
      i = -1;
    };
    };
  };
  for (int i = current_coord_1-1; i > -1; i--)
  {
   Array[i, current_coord_2] = numbers;
   numbers++;
   current_coord_1 = i;
    if (i != coord_1-1)
    {
    if (Array[i-1, current_coord_2] != 0)
    {
      i = -1;
    };
    };  
  }
  counter++;
  Direction_filler(Array_62,coord_a,coord_b,current_coord_1,current_coord_2,numbers,counter);
} 
else if (counter > 2)
{
  counter = 1;
  Direction_filler(Array_62,coord_a,coord_b,current_coord_1,current_coord_2,numbers,counter);
};
return 0;
};
Direction_filler(Array_62,coord_a,coord_b,current_coord_1,current_coord_2,numbers,counter);
Printer(Array_62, coord_a, coord_b);
