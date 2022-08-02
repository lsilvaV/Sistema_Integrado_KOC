import React from 'react';
import {NavigationContainer} from '@react-navigation/native';
import {createStackNavigator} from '@react-navigation/stack';


const navBotao = createStackNavigator();

import ListarCliente from './Listar';

export default function RotasBotao(){
    return(
        <navBotao.Navigator>
            <navBotao.Screen name="Listar" component={ListarCliente} options={{headerShown:false}} />
        </navBotao.Navigator>
    );
}