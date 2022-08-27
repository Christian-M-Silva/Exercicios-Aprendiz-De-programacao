import { Link } from "react-router-dom";

export function Header() {
    return(
        <header>
            <Link to={"/"} className="logo">DevFlix</Link>

            <Link to={"/favoritos"} className="favorite">Favoritos</Link>
        </header>
    )
}