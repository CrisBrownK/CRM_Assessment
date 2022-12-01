import React from 'react'
import { useEffect, useState } from 'react';
import axios from 'axios';
import {useNavigate} from "react-router-dom";
import "./Login.css";


export default function Login() {

  const navigate = useNavigate();

  const handleSubmit =(event) => {
    event.preventDefault();
    // window.location.href = "/ListaOportunidades"
    navigate('/ListaOportunidades')
  }

    let URLget = "https://localhost:7121/api/usuario/";
    let [userData, setUserData] = useState()

    function SubmitHandler(event){
      let email = document.getElementsByClassName("username")[0].value;
      let password = document.getElementsByClassName("password")[0].value;
      event.preventDefault();
      console.log(email, password);
      URLget += email + "/" + password;
      console.log(URLget);

      // var requestOptions = {
      //   method: 'GET',
      //   redirect: 'follow'
      // };

      // fetch(URLget, requestOptions)
      //  .then((response) => response.json())
      //  .then((response) => setUserData(response))
      //  .then((response) => console.log(response))
      //  .catch(error => console.log(error));

      //  console.log(userData.email);
      //  console.log(userData.contraseña);
      //     if(userData.email === email && userData.contraseña === password){
      //       handleSubmit();
      //     }
      //debugger;
      // useEffect(() => {
        axios.get(URLget)
         .then((response) => {
            console.log("hola")
            console.log(response)
            console.log("hola")
            console.log(response.data)
            setUserData(response.data)
          })
          .catch(error => console.log(error))

      // }, [])
      debugger;
      if(userData.email === email && userData.contraseña === password){
        navigate('/ListaOportunidades');
        //handleSubmit();
      }

    }



  return (
    <div className='containerLogin'>
      <div className='divTituloLogin'>
        <h2 className='tituloLogin'>Login</h2>
      </div>
      <form className='divLogin'>
        <div>
            <input
              type="text"
              className="username"
              name="username"
              placeholder="Email"
            />
        </div>
        <div>
            <input
              type="password"
              className="password"
              name="password"
              placeholder="Contraseña"
            />
        </div>
        <div>
            <button type="submit" className='btnLogin' onClick={SubmitHandler}>Login</button>
        </div>
      </form>
    </div>
  )
}

