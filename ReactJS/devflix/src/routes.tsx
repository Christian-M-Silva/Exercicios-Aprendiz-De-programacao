import { BrowserRouter, Routes, Route } from "react-router-dom"
import { Home } from "./pages/Home";
import { Detalhes } from "./pages/Detalhes";
import { NotFound } from "./pages/NotFound";
import { Header } from "./components/Header";
import { Favoritos } from "./pages/Favoritos";

export function RouterApp() {
    return(
        <BrowserRouter>
            <Header />
            <Routes>
                <Route path="/" element={ <Home /> } />
                <Route path="/detalhes/:id" element={ <Detalhes /> } />
                <Route path="/favoritos" element={ <Favoritos /> } />
                <Route path="*" element={ <NotFound /> } />
            </Routes>
        </BrowserRouter>
    )
}