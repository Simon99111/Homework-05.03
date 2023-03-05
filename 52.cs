using static Shares1;

int row = Input("Количество строк ");
int columns = Input("Количество столбцов ");
int [,] tableInt = MatrixInt(row, columns);
FillMatrixRandomInt(tableInt);
Console.WriteLine();
Sred(tableInt);