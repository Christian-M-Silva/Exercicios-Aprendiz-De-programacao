import { Link } from "react-router-dom"

export function Navegacao() {
    return(
        <header>
            <h1>Olá Pessoal</h1>
            <Link to="/">Home</Link> <br/>
            <Link to="/sobre">Sobre</Link> <br/>
            <Link to="/contato">Contato</Link>
        </header>
    )
}