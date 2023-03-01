using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Informe a quantidade de elementos do vetor: ");

    int n = int.Parse(Console.ReadLine());

    if(n>0){
      int[] vetor = new int[n];

      for(int i=0; i<n; i++){
        vetor[i] = int.Parse(Console.ReadLine());
        
      }
        Console.WriteLine();
      Console.WriteLine("Maior diferença é: " + maiorDiferenca(vetor));
      Console.WriteLine("O vetor está em ordem crescente? " + ordemCrescente(vetor));
      
    }
    
  }
  public static int maiorDiferenca(int[] vetor){
    int maior = vetor[0];
    int menor = vetor[0];

    for(int i=1; i< vetor.Length; i++){
       if (vetor[i] > maior){
         maior = vetor[i];
       }
         if(vetor[i] < menor){
           menor = vetor[i];
         }
       }
      return maior - menor;
    }
      public static bool ordemCrescente(int []vetor){
        for (int i=1; i<vetor.Length; i++){
          if(vetor[i] < vetor[i-1]){
            return false;
          }
          
        }
        return true;
      }
  
    }
