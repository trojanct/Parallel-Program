#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <omp.h>

int main(int argc, char* argv[])
{


	int t = 10;
	int mata[10][10];
	int matb[10][10];
	int matc[10][10];
	int i = 0;
	int j = 0;
	int l = 0;
	int result;
	clock_t start, final;
	double times;
	int tid = 99;



	for (i = 0; i < t; i++)
	{
		for (j = 0; j < t; j++)
		{
			//srand(time(NULL));
			mata[i][j] = rand() % 100 + 1;
			matb[i][j] = rand() % 100 + 1;
			matc[i][j] = 0;
		}
	}
	
	for (i = 0; i < t; i++)
	{
		for (j = 0; j < t; j++)
		{


			printf("%d", mata[i][j]);
		}
		printf("\n");
	}
	printf("\n");

	for (i = 0; i < t; i++)
	{
		for (j = 0; j < t; j++)
		{
			printf("%d", matb[i][j]);
		}
		printf("\n");
	}
	printf("\n");
	

	start = clock();
	//#pragma omp parallel for num_threads(5)
#pragma omp parallel for private(result,j,l)  num_threads(5)
	for (i = 0; i < t; i++)
	{
		printf(" %d handiling %d\n", omp_get_thread_num(),i);
		//#pragma omp parallel for private (result)  num_threads(5)
		for (j = 0; j < t; j++)
		{
			//#pragma omp parallel for reduction(+:result)  num_threads(5)
			for (l = 0; l < t; l++)
			{
			}
		}
	}
	final = clock();
	//times = (double)(final - start) / CLOCKS_PER_SEC;
	//printf("the time it took %f\n", times);
}
