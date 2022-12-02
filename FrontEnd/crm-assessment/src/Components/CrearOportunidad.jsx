import React from 'react'
import { useEffect, useState } from 'react';
import axios from 'axios';
import './CrearOportunidad.css';



const handleSubmit = () => {
 alert("Se ha guardado la información con éxito")
}

export default function CrearOportunidad() {

    let [userData, setUserData] = useState([]);

    function AddOportunidad(e) {
      e.preventDefault();
  
      let _nombre = document.querySelector('input[name="nombre"]').value;
      let _primerApellido = document.querySelector('input[name="primerApellido"]').value;
      let _segundoApellido = document.querySelector('input[name="segundoApellido"]').value;
      let _dni = document.querySelector('input[name="dni"]').value;
      let _telefono = document.querySelector('input[name="telefono"]').value;
      let _email = document.querySelector('input[name="email"]').value;
      let _motivo = document.querySelector('input[name="motivo"]').value;

        
        // var axios = require('axios');

        var myHeaders = new Headers();
        myHeaders.append("Content-Type", "application/json");
    
        var raw = JSON.stringify({

            nombre: _nombre,
            primerApellido: _primerApellido,
            segundoApellido: _segundoApellido,
            dni: _dni,
            telefono: _telefono,
            email: _email,
            idMotivo: _motivo
      
        });

        console.log(raw);
        let url = 'https://localhost:7121/addOportunidad';

        var requestOptions = {
            method: "POST",
            headers: myHeaders,
            body: raw
      
          };
        
        fetch(url, requestOptions)
        // .then(response => response.json())
        // .catch(error => console.log('error', error));


        // axios(config)
        // .then(function (response) {
        //     console.log(JSON.stringify(response.data));
        // })
        // .catch(function (error) {
        //     console.log(error);
        // });

        console.log(raw);
        handleSubmit();
    }

  return (
    <div>
        <div>
            <h2 className='titulo'>CREAR OPORTUNIDAD</h2>
        </div>
      <form>
        <input
        type="text"
        className="nombre"
        name="nombre"
        placeholder="Nombre"
        />
        <input
        type="text"
        className="primerApellido"
        name="primerApellido"
        placeholder="Primer Apellido"
        />
        <input
        type="text"
        className="segundoApellido"
        name="segundoApellido"
        placeholder="Segundo Apellido"
        />
        <input
        type="text"
        className="dni"
        name="dni"
        placeholder="DNI/CIF"
        />
        <input
        type="text"
        className="telefono"
        name="telefono"
        placeholder="Telefono"
        />
        <input
        type="text"
        className="email"
        name="email"
        placeholder="Correo Electrónico"
        />
        <input
        type="text"
        className="motivo"
        name="motivo"
        placeholder="Motivo del contacto"
        />
      </form>
      <div>
      <button type="submit" className='btnNuevaOportunidad' onClick={AddOportunidad}>Crear oportunidad</button>
      </div>
    </div>
  )
}

