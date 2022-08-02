import Api from './Api';

export async function buscarTodosClientes() {
    try {
      const resultado = await Api.get(`/kocdb`);
      return resultado.data;

    } catch (error) {

      console.log(error);
      return [];

    }
  }

export async function pesquisarNomeCliente(nomeCliente){
    try {
        const resultado = await Api.get(`/kocdb?nome=${nomeCliente}`);
        return resultado.data;
    } catch (error) {
        console.log(error);
        return [];
    }
}
