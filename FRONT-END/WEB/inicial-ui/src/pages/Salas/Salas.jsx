// Libs
import { Component } from "react";
import axios from "axios";
import {Link} from 'react-router-dom';

// Services
// import {parseJwt} from '../../services/Auth';

// Components
import MenuControle from '../../components/MenuControle';
import Modal from '../../components/Modal';

// Styles
import '../../assets/css/salas.css';
import '../../assets/css/reset.css';
import '../../assets/css/modal.css';

// Imgs
import icon from '../../assets/img/cards-lista-btn.svg';


class Salas extends Component {
    constructor(props){
        super(props);
        this.state = {
            isModalOpenCadastro : false
        }
    }

    
    render() {
        document.getElementById("modal").addEventListener("click", teste);
        function teste() {
            this.setState({isModalOpenCadastro : false})
        }
        
        return(
            <>
                <MenuControle />
                <div className="salas-background">
                    <div className="salas-btns">
                        <div className="salas-btns-cadastro">
                            <button onClick={() => this.setState({isModalOpenCadastro : true})}>Cadastrar Sala</button>
                        </div>

                        <div className="salas-btns-ordenar">
                            <button>Ordenar</button>
                        </div>
                    </div>

                    <div className="salas-lista">

                        <div className="salas-lista-card">
                            <button className="salas-card-click">
                                <div className="salas-card-btn-lateral">
                                    <img draggable="false" src={icon} />
                                </div>

                                <div className="salas-card-text">
                                    <div className="salas-card-text-item">
                                        <span className="salas-card-text-title">Sala</span>
                                        <p className="salas-card-text-content">Informática</p>
                                    </div>
                                    <div className="salas-card-text-item">
                                        <span className="salas-card-text-title">Andar</span>
                                        <p className="salas-card-text-content">Térreo</p>
                                    </div>
                                    <div className="salas-card-text-item">
                                        <span className="salas-card-text-title">Metragem</span>
                                        <p className="salas-card-text-content">14m²</p>
                                    </div>
                                </div>
                            </button>
                        </div>

                        <div className="salas-lista-card">
                            <button className="salas-card-click">
                                <div className="salas-card-btn-lateral">
                                    <img draggable="false" src={icon} />
                                </div>

                                <div className="salas-card-text">
                                    <div className="salas-card-text-item">
                                        <span className="salas-card-text-title">Sala</span>
                                        <p className="salas-card-text-content">Informática</p>
                                    </div>
                                    <div className="salas-card-text-item">
                                        <span className="salas-card-text-title">Andar</span>
                                        <p className="salas-card-text-content">Térreo</p>
                                    </div>
                                    <div className="salas-card-text-item">
                                        <span className="salas-card-text-title">Metragem</span>
                                        <p className="salas-card-text-content">14m²</p>
                                    </div>
                                </div>
                            </button>
                        </div>

                        <div className="salas-lista-card">
                            <button className="salas-card-click">
                                <div className="salas-card-btn-lateral">
                                    <img draggable="false" src={icon} />
                                </div>

                                <div className="salas-card-text">
                                    <div className="salas-card-text-item">
                                        <span className="salas-card-text-title">Sala</span>
                                        <p className="salas-card-text-content">Informática</p>
                                    </div>
                                    <div className="salas-card-text-item">
                                        <span className="salas-card-text-title">Andar</span>
                                        <p className="salas-card-text-content">Térreo</p>
                                    </div>
                                    <div className="salas-card-text-item">
                                        <span className="salas-card-text-title">Metragem</span>
                                        <p className="salas-card-text-content">14m²</p>
                                    </div>
                                </div>
                            </button>
                        </div>

                        <div className="salas-lista-card">
                            <button className="salas-card-click">
                                <div className="salas-card-btn-lateral">
                                    <img draggable="false" src={icon} />
                                </div>

                                <div className="salas-card-text">
                                    <div className="salas-card-text-item">
                                        <span className="salas-card-text-title">Sala</span>
                                        <p className="salas-card-text-content">Informática</p>
                                    </div>
                                    <div className="salas-card-text-item">
                                        <span className="salas-card-text-title">Andar</span>
                                        <p className="salas-card-text-content">Térreo</p>
                                    </div>
                                    <div className="salas-card-text-item">
                                        <span className="salas-card-text-title">Metragem</span>
                                        <p className="salas-card-text-content">14m²</p>
                                    </div>
                                </div>
                            </button>
                        </div>

                        <div className="salas-lista-card">
                            <button className="salas-card-click">
                                <div className="salas-card-btn-lateral">
                                    <img draggable="false" src={icon} />
                                </div>

                                <div className="salas-card-text">
                                    <div className="salas-card-text-item">
                                        <span className="salas-card-text-title">Sala</span>
                                        <p className="salas-card-text-content">Informática</p>
                                    </div>
                                    <div className="salas-card-text-item">
                                        <span className="salas-card-text-title">Andar</span>
                                        <p className="salas-card-text-content">Térreo</p>
                                    </div>
                                    <div className="salas-card-text-item">
                                        <span className="salas-card-text-title">Metragem</span>
                                        <p className="salas-card-text-content">14m²</p>
                                    </div>
                                </div>
                            </button>
                        </div>

                        <div className="salas-lista-card">
                            <button className="salas-card-click">
                                <div className="salas-card-btn-lateral">
                                    <img draggable="false" src={icon} />
                                </div>

                                <div className="salas-card-text">
                                    <div className="salas-card-text-item">
                                        <span className="salas-card-text-title">Sala</span>
                                        <p className="salas-card-text-content">Informática</p>
                                    </div>
                                    <div className="salas-card-text-item">
                                        <span className="salas-card-text-title">Andar</span>
                                        <p className="salas-card-text-content">Térreo</p>
                                    </div>
                                    <div className="salas-card-text-item">
                                        <span className="salas-card-text-title">Metragem</span>
                                        <p className="salas-card-text-content">14m²</p>
                                    </div>
                                </div>
                            </button>
                        </div>

                        <div className="salas-lista-card">
                            <button className="salas-card-click">
                                <div className="salas-card-btn-lateral">
                                    <img draggable="false" src={icon} />
                                </div>

                                <div className="salas-card-text">
                                    <div className="salas-card-text-item">
                                        <span className="salas-card-text-title">Sala</span>
                                        <p className="salas-card-text-content">Informática</p>
                                    </div>
                                    <div className="salas-card-text-item">
                                        <span className="salas-card-text-title">Andar</span>
                                        <p className="salas-card-text-content">Térreo</p>
                                    </div>
                                    <div className="salas-card-text-item">
                                        <span className="salas-card-text-title">Metragem</span>
                                        <p className="salas-card-text-content">14m²</p>
                                    </div>
                                </div>
                            </button>
                        </div>

                        <div className="salas-lista-card">
                            <button className="salas-card-click">
                                <div className="salas-card-btn-lateral">
                                    <img draggable="false" src={icon} />
                                </div>

                                <div className="salas-card-text">
                                    <div className="salas-card-text-item">
                                        <span className="salas-card-text-title">Sala</span>
                                        <p className="salas-card-text-content">Informática</p>
                                    </div>
                                    <div className="salas-card-text-item">
                                        <span className="salas-card-text-title">Andar</span>
                                        <p className="salas-card-text-content">Térreo</p>
                                    </div>
                                    <div className="salas-card-text-item">
                                        <span className="salas-card-text-title">Metragem</span>
                                        <p className="salas-card-text-content">14m²</p>
                                    </div>
                                </div>
                            </button>
                        </div>

                    </div>
                </div>

                <Modal isOpen={this.state.isModalOpenCadastro}>
                    <div className="modal" id="modal" onClick={() => this.setState({isModalOpenCadastro : false})}>
                        <div className="modaldasda">

                        </div>
                    </div>
                </Modal>
            </>
        )
    }
}

export default Salas;