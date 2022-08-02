import React, { useEffect, useState } from 'react';
import { StatusBar } from 'expo-status-bar';
import { Text, View, StyleSheet, FlatList, TouchableOpacity, Alert } from 'react-native';
import { useIsFocused } from '@react-navigation/native';
import { buscarTodosClientes } from './Model';

export default function ListarCliente({navigation}) {

  const [dadosCliente, setdadosCliente] = useState([]);
  const isFocused = useIsFocused();
    
  useEffect(async () => {
    const resp = await buscarTodosClientes();
    setdadosCliente(resp);
    
  },[isFocused]);

  return (
    <View style={estilo.container}>

      <Text style={estilo.titulo}>Lista de Clientes</Text>

      <StatusBar style="auto" />
    
          <FlatList
            data={dadosCliente}
            keyExtractor={dadosCliente => dadosCliente.id}
            renderItem={({ item }) =>
              <TouchableOpacity>
                <View style={estilo.grupoCliente}>

                  <Text style={estilo.textoBotaoCliente}>{item.nome}</Text>
                  <Text style={estilo.textoBotaoEmail}>{item.email}</Text>
                  <Text style={estilo.textoBotaoStatus}>{item.status}</Text>

                </View>
              </TouchableOpacity>

            }
          />
    </View>
  );
}


const estilo = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#0e0121',
  },
  titulo: {
    fontSize: 30,
    color: "#fff",
    textAlign: 'center',
    justifyContent: 'center',
    marginVertical: 20
  },
  grupoCliente: {
    backgroundColor: '#fff',
    margin: 15,
    padding: 5,
    borderRadius: 10,
    alignItems: 'center',
    justifyContent: 'center',
  },
  textoBotaoCliente: {
    fontSize: 20,
    color:"#000000"
  },
  textoBotaoEmail: {
    fontSize: 20
  },
  textoBotaoStatus: {
    fontSize: 20
  },
  botaoCadCliente: {
    backgroundColor: '#fff',
    margin: 15,
    padding: 5,
    borderRadius: 10,
  },
  botaoTextoCadCliente: {
    fontSize: 18,
    color:"#fff"
  }
});