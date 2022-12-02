import React, { useState } from'react';
import axios from 'axios'; 
import './App.css';
import ListaOportunidades from './Components/ListaOportunidades';
import Login from './Components/Login';
import { BrowserRouter, Routes, Route, Link, NavLink } from "react-router-dom";
import CrearOportunidad from './Components/CrearOportunidad';



function App() {

  return (
    <div className="App">
      <BrowserRouter>
        <Routes>
          <Route path="/" element={<Login />} />
          <Route path="/ListaOportunidades" element={<ListaOportunidades />} />
          <Route path="/CrearOportunidad" element={<CrearOportunidad />} />
        </Routes>
      </BrowserRouter>
    </div>
  );
}

export default App;
