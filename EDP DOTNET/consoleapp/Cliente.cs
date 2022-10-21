public class Cliente{

    public string nome {set;get;}
    
    private string codigoCliente {set; get;}
    
    protected string tokenDispositivoMovel = "X1DELTA";



public static string retornaQualquerCoisa(){
        return "aaaaaa";
    }

    public string retornaNome(){
        return nome;
    }


}








// : herança, herda
//clientePlatinum herda de Cliente

public class clientePlatinumMegaBlaster : Cliente {
public clientePlatinumMegaBlaster(){
    bool permissao = tokenDispositivoMovel == "X1DELTA";
    string texto = retornaQualquerCoisa();

}

    static void test(){
        
    }

}