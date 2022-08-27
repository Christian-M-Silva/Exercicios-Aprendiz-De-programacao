export function NotFound() {
    document.title="404 - Not Found"

    return(
        <div className="background-notFound">
            <div className="container-notFound">
                <h1 className="title-notFound">404</h1>
                <p className="conteudo-notFound">Ops, parece que essa seção está fechada :(</p>
            </div>
        </div>
    )
}