import { useParams } from 'react-router-dom' 

export function Produto() {
    const { id } = useParams()

    return(
        <h1>This is produto {id}</h1>
    )
}