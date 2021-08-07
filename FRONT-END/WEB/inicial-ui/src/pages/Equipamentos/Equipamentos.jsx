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
import '../../assets/css/equipamentos.css';
import '../../assets/css/reset.css';

// Imgs
import icon from '../../assets/img/cards-lista-btn.svg';
import sala from '../../assets/img/sala-modal-info-icon.svg';


class Equipamentos extends Component {
    constructor(props){
        super(props);
        this.state = {
            isModalOpenCadastro : false,
            isModalOpenInfo : false,
            isModalOpenEditar : false
        }
    }

    render() {
        return(
            <>
                <MenuControle />
                <div className="equipamentos-background">
                    <div className="equipamentos-btns">
                        <div className="equipamentos-btns-cadastro">
                            <button onClick={() => this.setState({isModalOpenCadastro : true})}>Cadastrar Equipamento</button>
                        </div>

                        <div className="equipamentos-btns-ordenar">
                            <button>Ordenar</button>
                        </div>
                    </div>

                    <div className="equipamentos-lista">

                        <div className="equipamentos-lista-card">
                            <button onClick={() => this.setState({isModalOpenInfo : true})} className="equipamentos-card-click">
                                <div className="equipamentos-card-btn-lateral">
                                    <img draggable="false" src={icon} />
                                </div>

                                <div className="equipamentos-card-text">
                                    <div className="equipamentos-card-text-item">
                                        <span className="equipamentos-card-text-title">Sala</span>
                                        <p className="salas-card-text-content">Informática</p>
                                    </div>
                                    <div className="equipamentos-card-text-item">
                                        <span className="equipamentos-card-text-title">Andar</span>
                                        <p className="equipamentos-card-text-content">Térreo</p>
                                    </div>
                                    <div className="equipamentos-card-text-item">
                                        <span className="equipamentos-card-text-title">Metragem</span>
                                        <p className="equipamentos-card-text-content">14m²</p>
                                    </div>
                                </div>
                            </button>
                        </div>

                        <div className="equipamentos-lista-card">
                            <button className="equipamentos-card-click">
                                <div className="equipamentos-card-btn-lateral">
                                    <img draggable="false" src={icon} />
                                </div>

                                <div className="equipamentos-card-text">
                                    <div className="equipamentos-card-text-item">
                                        <span className="equipamentos-card-text-title">Sala</span>
                                        <p className="salas-card-text-content">Informática</p>
                                    </div>
                                    <div className="equipamentos-card-text-item">
                                        <span className="equipamentos-card-text-title">Andar</span>
                                        <p className="equipamentos-card-text-content">Térreo</p>
                                    </div>
                                    <div className="equipamentos-card-text-item">
                                        <span className="equipamentos-card-text-title">Metragem</span>
                                        <p className="equipamentos-card-text-content">14m²</p>
                                    </div>
                                </div>
                            </button>
                        </div>

                        <div className="equipamentos-lista-card">
                            <button className="equipamentos-card-click">
                                <div className="equipamentos-card-btn-lateral">
                                    <img draggable="false" src={icon} />
                                </div>

                                <div className="equipamentos-card-text">
                                    <div className="equipamentos-card-text-item">
                                        <span className="equipamentos-card-text-title">Sala</span>
                                        <p className="salas-card-text-content">Informática</p>
                                    </div>
                                    <div className="equipamentos-card-text-item">
                                        <span className="equipamentos-card-text-title">Andar</span>
                                        <p className="equipamentos-card-text-content">Térreo</p>
                                    </div>
                                    <div className="equipamentos-card-text-item">
                                        <span className="equipamentos-card-text-title">Metragem</span>
                                        <p className="equipamentos-card-text-content">14m²</p>
                                    </div>
                                </div>
                            </button>
                        </div>

                        <div className="equipamentos-lista-card">
                            <button className="equipamentos-card-click">
                                <div className="equipamentos-card-btn-lateral">
                                    <img draggable="false" src={icon} />
                                </div>

                                <div className="equipamentos-card-text">
                                    <div className="equipamentos-card-text-item">
                                        <span className="equipamentos-card-text-title">Sala</span>
                                        <p className="salas-card-text-content">Informática</p>
                                    </div>
                                    <div className="equipamentos-card-text-item">
                                        <span className="equipamentos-card-text-title">Andar</span>
                                        <p className="equipamentos-card-text-content">Térreo</p>
                                    </div>
                                    <div className="equipamentos-card-text-item">
                                        <span className="equipamentos-card-text-title">Metragem</span>
                                        <p className="equipamentos-card-text-content">14m²</p>
                                    </div>
                                </div>
                            </button>
                        </div>
                        
                        <div className="equipamentos-lista-card">
                            <button className="equipamentos-card-click">
                                <div className="equipamentos-card-btn-lateral">
                                    <img draggable="false" src={icon} />
                                </div>

                                <div className="equipamentos-card-text">
                                    <div className="equipamentos-card-text-item">
                                        <span className="equipamentos-card-text-title">Sala</span>
                                        <p className="salas-card-text-content">Informática</p>
                                    </div>
                                    <div className="equipamentos-card-text-item">
                                        <span className="equipamentos-card-text-title">Andar</span>
                                        <p className="equipamentos-card-text-content">Térreo</p>
                                    </div>
                                    <div className="equipamentos-card-text-item">
                                        <span className="equipamentos-card-text-title">Metragem</span>
                                        <p className="equipamentos-card-text-content">14m²</p>
                                    </div>
                                </div>
                            </button>
                        </div>

                        <div className="equipamentos-lista-card">
                            <button className="equipamentos-card-click">
                                <div className="equipamentos-card-btn-lateral">
                                    <img draggable="false" src={icon} />
                                </div>

                                <div className="equipamentos-card-text">
                                    <div className="equipamentos-card-text-item">
                                        <span className="equipamentos-card-text-title">Sala</span>
                                        <p className="salas-card-text-content">Informática</p>
                                    </div>
                                    <div className="equipamentos-card-text-item">
                                        <span className="equipamentos-card-text-title">Andar</span>
                                        <p className="equipamentos-card-text-content">Térreo</p>
                                    </div>
                                    <div className="equipamentos-card-text-item">
                                        <span className="equipamentos-card-text-title">Metragem</span>
                                        <p className="equipamentos-card-text-content">14m²</p>
                                    </div>
                                </div>
                            </button>
                        </div>

                        <div className="equipamentos-lista-card">
                            <button className="equipamentos-card-click">
                                <div className="equipamentos-card-btn-lateral">
                                    <img draggable="false" src={icon} />
                                </div>

                                <div className="equipamentos-card-text">
                                    <div className="equipamentos-card-text-item">
                                        <span className="equipamentos-card-text-title">Sala</span>
                                        <p className="salas-card-text-content">Informática</p>
                                    </div>
                                    <div className="equipamentos-card-text-item">
                                        <span className="equipamentos-card-text-title">Andar</span>
                                        <p className="equipamentos-card-text-content">Térreo</p>
                                    </div>
                                    <div className="equipamentos-card-text-item">
                                        <span className="equipamentos-card-text-title">Metragem</span>
                                        <p className="equipamentos-card-text-content">14m²</p>
                                    </div>
                                </div>
                            </button>
                        </div>

                        <div className="equipamentos-lista-card">
                            <button className="equipamentos-card-click">
                                <div className="equipamentos-card-btn-lateral">
                                    <img draggable="false" src={icon} />
                                </div>

                                <div className="equipamentos-card-text">
                                    <div className="equipamentos-card-text-item">
                                        <span className="equipamentos-card-text-title">Sala</span>
                                        <p className="salas-card-text-content">Informática</p>
                                    </div>
                                    <div className="equipamentos-card-text-item">
                                        <span className="equipamentos-card-text-title">Andar</span>
                                        <p className="equipamentos-card-text-content">Térreo</p>
                                    </div>
                                    <div className="equipamentos-card-text-item">
                                        <span className="equipamentos-card-text-title">Metragem</span>
                                        <p className="equipamentos-card-text-content">14m²</p>
                                    </div>
                                </div>
                            </button>
                        </div>

                        <div className="equipamentos-lista-card">
                            <button className="equipamentos-card-click">
                                <div className="equipamentos-card-btn-lateral">
                                    <img draggable="false" src={icon} />
                                </div>

                                <div className="equipamentos-card-text">
                                    <div className="equipamentos-card-text-item">
                                        <span className="equipamentos-card-text-title">Sala</span>
                                        <p className="salas-card-text-content">Informática</p>
                                    </div>
                                    <div className="equipamentos-card-text-item">
                                        <span className="equipamentos-card-text-title">Andar</span>
                                        <p className="equipamentos-card-text-content">Térreo</p>
                                    </div>
                                    <div className="equipamentos-card-text-item">
                                        <span className="equipamentos-card-text-title">Metragem</span>
                                        <p className="equipamentos-card-text-content">14m²</p>
                                    </div>
                                </div>
                            </button>
                        </div>

                        <div className="equipamentos-lista-card">
                            <button className="equipamentos-card-click">
                                <div className="equipamentos-card-btn-lateral">
                                    <img draggable="false" src={icon} />
                                </div>

                                <div className="equipamentos-card-text">
                                    <div className="equipamentos-card-text-item">
                                        <span className="equipamentos-card-text-title">Sala</span>
                                        <p className="salas-card-text-content">Informática</p>
                                    </div>
                                    <div className="equipamentos-card-text-item">
                                        <span className="equipamentos-card-text-title">Andar</span>
                                        <p className="equipamentos-card-text-content">Térreo</p>
                                    </div>
                                    <div className="equipamentos-card-text-item">
                                        <span className="equipamentos-card-text-title">Metragem</span>
                                        <p className="equipamentos-card-text-content">14m²</p>
                                    </div>
                                </div>
                            </button>
                        </div>
                        

                    </div>
                </div>

                <Modal isOpen={this.state.isModalOpenInfo}>
                    <div className="modal">
                        <div className="modal-card-background-info-equipamentos">
                            <div className="modal-card-background-info-equipamentos-lateral">
                                <img draggable="false" src={icon} />
                            </div>

                            <div className="modal-card-background-info-equipamentos-content">
                                <div className="modal-card-background-info-equipamentos-content-title">
                                    <p>Informações do Equipamento</p>
                                    <button onClick={() => this.setState({isModalOpenInfo : false})}>x</button>
                                </div>

                                <div className="modal-card-background-info-equipamentos-text">
                                    <div className="modal-card-background-info-equipamentos-content-item">
                                        <span className="modal-card-background-info-equipamentos-content-item-title">Equipamento</span>
                                        <p className="modal-card-background-info-equipamentos-content-item-sub">Esqueleto Anatômico</p>
                                    </div>

                                    <div className="modal-card-background-info-equipamentos-content-item">
                                        <span className="modal-card-background-info-equipamentos-content-item-title">Tipo de Equipamento</span>
                                        <p className="modal-card-background-info-equipamentos-content-item-sub">Dell Inspiron 15</p>
                                    </div>

                                    <div className="modal-card-background-info-equipamentos-content-item">
                                        <span className="modal-card-background-info-equipamentos-content-item-title">N° Patrimônio</span>
                                        <p className="modal-card-background-info-equipamentos-content-item-sub">13200001</p>
                                    </div>

                                    <div className="modal-card-background-info-equipamentos-content-item">
                                        <span className="modal-card-background-info-equipamentos-content-item-title">Marca</span>
                                        <p className="modal-card-background-info-equipamentos-content-item-sub">Laborglass</p>
                                    </div>

                                    <div className="modal-card-background-info-equipamentos-content-item">
                                        <span className="modal-card-background-info-equipamentos-content-item-title">N° Série</span>
                                        <p className="modal-card-background-info-equipamentos-content-item-sub">20210729001</p>
                                    </div>

                                    <div className="modal-card-background-info-equipamentos-content-item">
                                        {/* <span className="modal-card-background-info-equipamentos-content-item-title"></span> */}
                                        <p className="modal-card-background-info-equipamentos-content-item-sub-situacao">Indisponível</p>
                                    </div>

                                    <div className="modal-card-background-info-equipamentos-content-item">
                                        <span className="modal-card-background-info-equipamentos-content-item-title">Descrição</span>
                                        <p className="modal-card-background-info-equipamentos-content-item-sub">Esqueleto anatômico para o uso nas aulas de biologia</p>
                                    </div>

                                </div>
                                <div className="modal-card-background-info-equipamentos-content-btns">
                                    <button onClick={() => this.setState({isModalOpenInfo : false, isModalOpenEditar : true})} className="modal-card-background-info-equipamentos-content-btns-btn">Editar</button>
                                    <button onClick={() => this.setState({isModalOpenCadastro : false})} className="modal-card-background-info-equipamentos-content-btns-btn">Excluir</button>
                                </div>

                            </div>

                        </div>
                    </div>
                </Modal>

                <Modal isOpen={this.state.isModalOpenCadastro}>
                    <div className="modal">
                        <div className="modal-card-background-equipamentos">
                            <div className="modal-card-title">
                                <p>Cadastrar Equipamento</p>
                            </div>

                            <div className="modal-card-form">
                                <input type="text" placeholder="Nome do equipamento" className="modal-card-form-input-nome" />

                                <div className="modal-card-form-input-patrimonio-marca">
                                    <div className="modal-card-form-input-patrimonio-content">
                                        <input type="text" placeholder="N° Patrimônio" className="modal-card-form-input-patrimonio" />
                                    </div>
                                    <div className="modal-card-form-input-marca-content">
                                        <input type="text" placeholder="Marca" className="modal-card-form-input-marca" />
                                    </div>
                                    {/* <select value="Metragem (m²)" className="modal-card-form-input-andar" /> */}
                                </div>

                                <div className="modal-card-form-input-serie-situacao">
                                    <div className="modal-card-form-input-serie-content">
                                        <input type="text" placeholder="N° Série" className="modal-card-form-input-serie" />
                                    </div>
                                    
                                    <select className="modal-card-form-input-situacao"><option>Situação</option></select>
                                </div>

                                <input type="text" placeholder="Descrição" className="modal-card-form-input-descricao" />

                            </div>
                            <div className="modal-card-form-btns">
                                <button className="modal-card-form-btns-btn">Cadastrar</button>
                                <button onClick={() => this.setState({isModalOpenCadastro : false})} className="modal-card-form-btns-btn">Cancelar</button>
                            </div>
                        </div>
                    </div>
                </Modal>

                <Modal isOpen={this.state.isModalOpenEditar}>
                    <div className="modal">
                        <div className="modal-card-background-equipamentos">
                            <div className="modal-card-title">
                                <p>Editar Equipamento</p>
                            </div>

                            <div className="modal-card-form">
                                <input type="text" placeholder="Nome do equipamento" className="modal-card-form-input-nome" />

                                <div className="modal-card-form-input-patrimonio-marca">
                                    <div className="modal-card-form-input-patrimonio-content">
                                        <input type="text" placeholder="N° Patrimônio" className="modal-card-form-input-patrimonio" />
                                    </div>
                                    <div className="modal-card-form-input-marca-content">
                                        <input type="text" placeholder="Marca" className="modal-card-form-input-marca" />
                                    </div>
                                    {/* <select value="Metragem (m²)" className="modal-card-form-input-andar" /> */}
                                </div>

                                <div className="modal-card-form-input-serie-situacao">
                                    <div className="modal-card-form-input-serie-content">
                                        <input type="text" placeholder="N° Série" className="modal-card-form-input-serie" />
                                    </div>
                                    
                                    <select className="modal-card-form-input-situacao"><option>Situação</option></select>
                                </div>

                                <input type="text" placeholder="Descrição" className="modal-card-form-input-descricao" />

                            </div>
                            <div className="modal-card-form-btns">
                                <button className="modal-card-form-btns-btn">Editar</button>
                                <button onClick={() => this.setState({isModalOpenEditar : false})} className="modal-card-form-btns-btn">Cancelar</button>
                            </div>
                        </div>
                    </div>
                </Modal>

            </>
        )
    }
}

export default Equipamentos;