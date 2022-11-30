import React, { useState } from'react';
import axios from 'axios'; 
import './App.css';



function App() {

const [data, setData] = useState([]);
axios.get("https://localhost:7121/api/oportunidad").then(response => setData(response.data)); 
console.log(data);
  return (
    <div className="App">
      {data[0]}
    </div>
  );
}

export default App;
