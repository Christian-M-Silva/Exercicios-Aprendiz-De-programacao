import logo from './logo.svg';
import './App.css';
import Header from './Header';
import { useState } from 'react';

function App() {

  const[cont, setCont] = useState(0);

  function clicando(){
    setCont(cont+1);
  }

  return (
    <div className="App">
      <Header title={cont}/>

      <button onClick= {clicando}>Quantos patos eu tenho?</button>
    </div>
  );
}

export default App;
