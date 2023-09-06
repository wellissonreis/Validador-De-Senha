
bool ValidatePassword(string senha)
{
    char[] arrSenha = senha.ToCharArray();
    string aux = "Cod->";

    if (arrSenha.Count() > 8)
    {
        foreach (char c in arrSenha)
        {            
            if (char.IsUpper(c))
            {
                aux = aux + 'U';
            }

            if (char.IsLower(c))
            {
                aux = aux + 'l';
            }

            if (char.IsNumber(c))
            {
                aux+= 'n';
            }

            if (char.IsPunctuation(c))
            {
                aux+= 'p';
            }

            if(aux.Contains('U') && aux.Contains('l') && aux.Contains('n') && aux.Contains('p'))
            {
                Console.WriteLine("Usuario cadastrado com sucesso!");
                return true;
            }
        }
        if(aux.Contains('U') == false)
        {
            Console.WriteLine("Insira ao menos uma letra maiuscula!");
        }
        else if (aux.Contains('l') == false)
        {
            Console.WriteLine("Insira ao menos uma letra minuscula!");
        }
        else if (aux.Contains('n') == false)
        {
            Console.WriteLine("Insira ao menos uma um numero!");
        }
        else if (aux.Contains('p') == false)
        {
            Console.WriteLine("Insira ao menos uma caracter!");
        }
    }
    else
    {
        Console.WriteLine("Número de caracters inválidos");
    }
    return false;
}

bool senhaValida = ValidatePassword("Senha123!");
Console.WriteLine(senhaValida); // Deve imprimir "True"

bool senhaInvalida = ValidatePassword("abcde");
Console.WriteLine(senhaInvalida); // Deve imprimir "False"