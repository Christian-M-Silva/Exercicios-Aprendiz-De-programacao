import logo from './logo.svg';
import './App.css';
import Header from './Header';

function clicando(){
  alert ('Você clicou no botão!')
}

function douglas(){
  alert ('Eu sou o Douglas')
}

function App() {
  return (
    <div className="App">
      <header>
        
        <Header/>
        
        <button onClick= {clicando}>Clique here</button>
        <button onClick= {douglas}>Você não é o Douglas</button>
      </header>
    </div>
  );
}

export default App;
