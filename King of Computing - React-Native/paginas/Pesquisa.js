import React, {useState} from 'react';
import { StatusBar } from 'expo-status-bar';
import {Text, View, StyleSheet,TextInput,TouchableOpacity,Alert} from 'react-native';
import {pesquisarNomeCliente} from './Model';


export default function Pesquisa(){

const [dadosCliente, setdadosCliente] = useState([]);

async function buscarClientes(){
  const resultado = await pesquisarNomeCliente(nomeCliente);
  if (resultado) {
    setdadosCliente(resultado);
  } else {
    Alert.alert('Cliente não encontrado!!');
    setdadosCliente('');
  }
}

//--comentario --//

 return(
    <View style={estilo.container}>
     <Text style={estilo.titulo}>Digite o código do cliente.</Text>
      <TextInput 
      style={estilo.textInput}
      />
      
      <TouchableOpacity style={estilo.botao} onPress={()=> buscarClientes()}>
          <Text style={estilo.textoBotao} >Pesquisar</Text>
      </TouchableOpacity>

      <StatusBar style="auto" />
    </View>
 );   
}

const estilo = StyleSheet.create({
    container: {
      flex: 1,
      backgroundColor: '#0e0121',
      alignItems: 'center',
      justifyContent: 'center',
    },
    textInput:{
      borderColor:'#fff',
      fontSize:20,
      width:'80%',
      height:30,
      borderWidth:2,
      borderRadius:8,
      marginTop:30,
      paddingHorizontal:10,
      color: "white"
    },
    botao:{
      backgroundColor:"#fff",
      marginTop:15,
      padding:10,
      borderRadius:15,
      width:'80%',
      justifyContent:'center',
      alignItems:'center'
    },
    textoBotao:{
      fontSize: 18,
      fontWeight: '700',
      color:'#000000'
    },
    titulo:{
      fontSize:30,
      color:"#fff"
    }
  });