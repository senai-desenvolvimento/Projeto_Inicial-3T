// Libs
import { Component } from "react";
import axios from "axios";
import {Link} from 'react-router-dom';

// Services
// import {parseJwt} from '../../services/Auth';

// Components
import MenuControle from '../../components/MenuControle';

// Styles
import '../../assets/css/salas.css';
import '../../assets/css/reset.css';


class Salas extends Component {
    constructor(props){
        super(props);
        this.state = {
            x : ''
        }
    }

    render() {
        return(
            <>
                <MenuControle />
                <div className="salas-background">
                    <div className="salas-btns">
                        <div className="salas-btns-cadastro">
                            <button>Cadastrar Sala</button>
                        </div>

                        <div className="salas-btns-ordenar">
                            <button>Ordenar</button>
                        </div>
                    </div>

                    <div className="salas-lista">

                        <div className="salas-lista-card">

                        </div>

                        <div className="salas-lista-card">
                            
                        </div>

                        <div className="salas-lista-card">
                            
                        </div>

                        <div className="salas-lista-card">
                            
                        </div>

                        <div className="salas-lista-card">
                            
                        </div>

                        <div className="salas-lista-card">
                            
                        </div>

                        <div className="salas-lista-card">
                            
                        </div>

                        <div className="salas-lista-card">
                            
                        </div>

                        <div className="salas-lista-card">
                            
                        </div>

                        <div className="salas-lista-card">
                            
                        </div>

                    </div>
                </div>
            </>
        )
    }
}

export default Salas;