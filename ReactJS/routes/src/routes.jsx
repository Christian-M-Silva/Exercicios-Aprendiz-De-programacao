import { BrowserRouter, Routes, Route } from 'react-router-dom'
import { Home } from './pages/Home/'
import { Sobre } from './pages/Sobre'
import { Contato } from './pages/Contato'
import { Navegacao } from './components/Navegacao'
import { Erro } from './pages/Erro'
import { Produto } from './pages/produto'

export function RouterApp() {
    return(
        <BrowserRouter>
            <Navegacao />
            <Routes>
                <Route path="/" element={ <Home /> } />
                <Route path="/sobre" element={ <Sobre /> } />
                <Route path="/contato" element={ <Contato /> } />
                <Route path="/produtos/:id" element={ <Produto /> } />
                <Route path="*" element={ <Erro />} />
            </Routes>
        </BrowserRouter>
    )
}