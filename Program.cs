using System;
using System.Collections.Generic;
using System.Linq;

class MinhaClasse {
  public static void Main (string[] args) {
    

    string input;
    List<string> passwords = new List<string>();
    while (!string.IsNullOrEmpty(input = Console.ReadLine())){
        passwords.Add(input);
    }

    for (int i = 0; i < passwords.Count; i++)
    {
    string senha = passwords[i];




    int simbolo = 0;

    string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_, ";
        foreach (var item in specialChar)
        {
            if (senha.Contains(item))
            {
                simbolo = 1;
            }
        }

    if ((senha.Length >= 6) && (senha.Length <= 32) && (simbolo == 0) )
    {
        if (senha.Any(char.IsUpper) && senha.Any(char.IsLower) && senha.Any(char.IsDigit))
        {
            Console.WriteLine("Senha valida.");
        }
        else
        {
            Console.WriteLine("Senha invalida.");
        }
    }
    else
    {
        Console.WriteLine("Senha invalida.");
    }

    }

    }
  
}