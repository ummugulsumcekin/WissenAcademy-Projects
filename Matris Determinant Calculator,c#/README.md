Determinant Calculator


This is a C# console application that calculates the determinant of a square matrix.

Usage ;

Run the program
Enter the size of the matrix (e.g. 3 for a 3x3 matrix)
Enter the elements of the matrix one by one
The program will output the determinant of the matrix
Note: The program only accepts integer input.

Implementation Details ;


The program uses a recursive algorithm to calculate the determinant of the matrix. If the size of the matrix is 1, the determinant is simply the value of the element in the matrix. If the size of the matrix is 2, the determinant is calculated using the formula:determinant = a11 * a22 - a12 * a21
For larger matrices, the program recursively calculates the determinant of submatrices until it reaches a 2x2 matrix, which is then calculated using the formula above.

The program also includes a function to get a submatrix by removing a specified column from the matrix. This function is used to calculate the determinant of the submatrices.
![matrisdeterminantcalculator](https://github.com/ummugulsumcekin/WissenAcademy-Projects/assets/102469765/b843393c-159d-454d-9385-7094f3c0e961)
