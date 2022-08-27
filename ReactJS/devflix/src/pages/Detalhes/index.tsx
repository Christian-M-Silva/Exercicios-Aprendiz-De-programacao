import { useParams } from "react-router-dom"

export function Detalhes() {
    const { id } = useParams()

    document.title="DevFlix - Detalhes"

    return(
        <h1>Pag de Detalhes do id {id}</h1>
    )
}