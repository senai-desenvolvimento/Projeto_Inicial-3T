// Libs
import React, {Component} from 'react';
import axios from 'axios';
import {Link} from 'react-router-dom';

// Styles
import '../assets/css/reset.css';
import '../assets/css/menuControle.css';

// Imgs
import sair from '../assets/img/menu-controle-sair.svg';


class MenuControle extends Component{
    render() {
        const URL = window.location.pathname;
        console.log(URL);
        return(
            <>
                <div className="menu-controle-background">
                    <div className="menu-controle">

                        <div className="menu-controle-content">
                            <div className="menu-controle-text">
                                <p className="menu-controle-text-title">Painel de Controle</p>
                                <div className="menu-controle-pages">
                                    <div className={URL === '/salas' ? 'menu-controle-pages-page' : 'menu-controle-pages-page-disable'}>
                                        <Link to="/salas">
                                            <p className={URL === '/salas' ? 'menu-controle-pages-title' : 'menu-controle-pages-title-disable'}>Salas</p>
                                            <p className={URL === '/salas' ? 'menu-controle-pages-span' : 'menu-controle-pages-span-disable'}>(6)</p>
                                        </Link>
                                    </div>

                                    <div className={URL === '/equipamentos' ? 'menu-controle-pages-page' : 'menu-controle-pages-page-disable'}>
                                        <Link to="/equipamentos">
                                            <p className={URL === '/equipamentos' ? 'menu-controle-pages-title' : 'menu-controle-pages-title-disable'}>Equipamentos</p>
                                            <p className={URL === '/equipamentos' ? 'menu-controle-pages-span' : 'menu-controle-pages-span-disable'}>(10)</p>
                                        </Link>
                                    </div>
                                </div>
                            </div>

                            <div className="menu-controle-logout">
                                <div className="menu-controle-logout-btn">
                                    <a href="#">
                                        <p className="menu-controle-logout-btn-title">Sair</p>
                                        <img draggable="false" src={sair} />
                                    </a>
                                </div>
                            </div>
                        </div>

                    </div>
                </div>
            </>
        )
    }
}

export default MenuControle;