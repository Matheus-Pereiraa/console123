namespace mvc2_MtheusPereira.Models
{
    public class aUsuario
    {

        public string Logar;

        public void CriarPastaEArquivo(string _caminho){
            string folder   = _caminho.Split("/")[0];
            string file     = _caminho.Split("/")[1];
        }
    }
}