import React from 'react'
import axios from 'axios';
import { useEffect, useState } from 'react';
import './ListaOportunidades.css';

export default function ListaOportunidades() {

    const URLget = "https://localhost:7121/api/oportunidad";
    const [data, setData] = useState([])

    useEffect(() => {
        axios.get(URLget)
           .then((response) => {
                console.log(response);
                console.log(response.data);
                console.log(response.headers);
                setData(response.data)
           })
           .catch(error => console.log(error))
    }, [])

    const arrayData = data.map((data, index) =>{
        return(
        <tr>
            <td>{data.nombre}</td>
            <td>{data.primerApellido}</td>
            <td>{data.telefono}</td>
            <td>{data.email}</td>
            <td>{data.idMotivo}</td>
        </tr>
        )
        
    })

    return (
        <div>
            <div>
                <h2 className="titulo">LISTA OPORTUNIDADES</h2>
            </div>
            <table className="tabla">
                <tr>
                    <th>NOMBRE</th>
                    <th>APELLIDO</th>
                    <th>TELEFONO</th>
                    <th>EMAIL</th>
                    <th>MOTIVO</th>
                </tr>
                {arrayData}
            </table>
        </div>
    )
}



